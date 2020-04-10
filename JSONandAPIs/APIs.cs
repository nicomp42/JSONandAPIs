/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */
// Install Newtonsoft.Json

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace JSONandAPIs
{
    class APIs
    {
        public static void GSMNPAlerts(TextBox txtAlerts)
        {
            var client = new WebClient();
            // You can also open the URL in a browser to see the JSON data interpreted by the browser. 
            var jsonString = client.DownloadString("https://developer.nps.gov/api/v1/alerts?parkCode=grsm&api_key=pfJKDXPzTykVL73ehnPyY8pkDQLjfq5cz5LqCkl3");
            JObject json = JObject.Parse(jsonString);      // NewtonSoft !
            Console.WriteLine(json);                        // All the JSON. Note there are "total", "data", "limit", "start" elements here

            JToken dataToken = json.GetValue("data");       // There's a thing called "data" in the JSON data
            Console.WriteLine(dataToken[0]);                // The first element in "data". Everything inside the outer {} delimiters of the "data" item because there's only one item
            Console.WriteLine(dataToken[0]["title"]);       // There's a thing called "title" in the JSON data
            String description = dataToken[0]["description"].ToString();
            txtAlerts.Text = description;

            var myDictionary = deserializeToDictionary(jsonString);
            Console.WriteLine("Dumping the JSON:");
            foreach (KeyValuePair<string, object> entry in myDictionary) {
                Console.WriteLine(entry.Value.GetType());
                Console.WriteLine(entry.Key + ": " + entry.Value);
            }
        }
        /// <summary>
        /// Info for Great Smokey Mountains National Park
        /// </summary>
        public static void GSMNPInfo(TextBox txtDescription)
        {
            var client = new WebClient();
            // You can also open the URL in a browser to see the JSON data interpreted by the browser. 
            var jsonString = client.DownloadString("https://developer.nps.gov/api/v1/parks?parkCode=grsm&api_key=pfJKDXPzTykVL73ehnPyY8pkDQLjfq5cz5LqCkl3");
            //            Console.WriteLine(text);
            //          https://www.newtonsoft.com/json/help/html/T_Newtonsoft_Json_Linq_JObject.htm
            JObject json = JObject.Parse(jsonString);      // NewtonSoft !
            // Let's get the phone numbers. There is only one but we shouldn't assume that will always be the case
            JToken dataToken = json.GetValue("data");       // There's a thing called "data" in the JSON data
            JToken contactsToken = dataToken[0]["contacts"];
            JToken phoneNumbersToken = contactsToken["phoneNumbers"];

            foreach (JToken phoneNumberToken in phoneNumbersToken) {
                txtDescription.AppendText(phoneNumberToken["phoneNumber"].ToString() + Environment.NewLine);
            }
            // Images
            foreach (JToken imageToken in dataToken[0]["images"]) {
                txtDescription.AppendText(imageToken["url"].ToString() + Environment.NewLine);
            }
        }
        private static Dictionary<string, object> deserializeToDictionary(string jsonString)
        {
            // https://stackoverflow.com/questions/1207731/how-can-i-deserialize-json-to-a-simple-dictionarystring-string-in-asp-net
            var values = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonString);
            var values2 = new Dictionary<string, object>();
            foreach (KeyValuePair<string, object> d in values)
            {
                // if (d.Value.GetType().FullName.Contains("Newtonsoft.Json.Linq.JObject"))
                if (d.Value is JObject) {
                    values2.Add(d.Key, deserializeToDictionary(d.Value.ToString()));
                } else {
                    values2.Add(d.Key, d.Value);
                }
            }
            return values2;
        }
    }
}
