using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Globalization;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace ZapposWebApplication
{

public partial class ZapposTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(TextBox1.Text) || String.IsNullOrEmpty(TextBox2.Text))
        {
            MessageBox.Show("Please Enter Values in Both The fields ! Thank You ");
        }

        else
        {
            try
            {
                var p = new Program();
                const string url = "http://api.zappos.com/Search?term=gift&filters={%22isNew%22:[%22true%22]}&excludes=[%22styleId%22,%22filters%22,%22term%22,%22isNew%22,%22totalResultCount%22,%22currentResultCount%22,%22originalTerm%22,%22productUrl%22,%22colorId%22,%22productId%22,%22originalPrice%22,%22brandName%22,%22limit%22,%22statusCode%22,%22thumbnailImageUrl%22,%22percentOff%22]&limit=100&key=12c3302e49b9b40ab8a222d7cf79a69ad11ffd78";
                var var1 = p.GiveList(url);
                var finalSortedList = new List<double>(var1.Values);
                finalSortedList.Sort();

                
                var sortedListArray = finalSortedList.ToArray();
                var noOfItems = Double.Parse(TextBox1.Text);
                var sum = Double.Parse(TextBox2.Text);
                var sortObject = new Sort();
                var doubleResult = sortObject.FinalSort(noOfItems, sum, sortedListArray).ToArray();

                TextBox3.Text = "";
                
               
                foreach (double t in doubleResult)
                {
                   
                    var s = var1.ElementAt((var1.IndexOfValue(t))).ToString();
                    var sres = s.Split(',');
                    var tempInd = sres[1].IndexOf(']');
                    TextBox3.Text += "Item Name :" + sres[0].Substring(1) + " : $" +
                                     sres[1].Substring(0,tempInd ) +
                                     Environment.NewLine + Environment.NewLine;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter digits in Both The fields ! Thank You ");
            }
        }
    }

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(TextBox1.Text) || String.IsNullOrEmpty(TextBox2.Text))
        {
            MessageBox.Show("Please Enter Values in Both The fields ! Thank You ");
        }

        else
        {
            try
            {
                var p = new Program();
                const string url = "http://api.zappos.com/Search?term=gift&sort={%22price%22:%22asc%22}&excludes=[%22styleId%22,%22filters%22,%22term%22,%22isNew%22,%22totalResultCount%22,%22currentResultCount%22,%22originalTerm%22,%22productUrl%22,%22colorId%22,%22productId%22,%22originalPrice%22,%22brandName%22,%22limit%22,%22statusCode%22,%22thumbnailImageUrl%22,%22percentOff%22]&limit=100&key=12c3302e49b9b40ab8a222d7cf79a69ad11ffd78";
                var var1 = p.GiveList(url);
                var finalSortedList = new List<double>(var1.Values);
                finalSortedList.Sort();

               
                var sortedListArray = finalSortedList.ToArray();
                var noOfItems = Double.Parse(TextBox1.Text);
                var sum = Double.Parse(TextBox2.Text);
                var sortObject = new Sort();
                var doubleResult = sortObject.FinalSort(noOfItems, sum, sortedListArray).ToArray();
                
                TextBox3.Text = "";
                
               
                foreach (double t in doubleResult)
                {
                     
                    var s = var1.ElementAt((var1.IndexOfValue(t))).ToString();
                    var sres = s.Split(',');
                    var tempInd = sres[1].IndexOf(']');
                    TextBox3.Text += "Item Name :" + sres[0].Substring(1) + " : $" +
                                     sres[1].Substring(0, tempInd) +
                                     Environment.NewLine + Environment.NewLine;
                    
                }
            }
            catch (FormatException )
            {
                MessageBox.Show("Please Enter digits in Both The fields ! Thank You ");
            }
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(TextBox1.Text) || String.IsNullOrEmpty(TextBox2.Text))
        {
            MessageBox.Show("Please Enter Values in Both The fields ! Thank You ");
        }

        else
        {
            try
            {
                var p = new Program();
                const string url = "http://api.zappos.com/Search?term=gift&sort={%22price%22:%22desc%22}&excludes=[%22styleId%22,%22filters%22,%22term%22,%22isNew%22,%22totalResultCount%22,%22currentResultCount%22,%22originalTerm%22,%22productUrl%22,%22colorId%22,%22productId%22,%22originalPrice%22,%22brandName%22,%22limit%22,%22statusCode%22,%22thumbnailImageUrl%22,%22percentOff%22]&limit=100&key=12c3302e49b9b40ab8a222d7cf79a69ad11ffd78";
                var var1 = p.GiveList(url);
                var finalSortedList = new List<double>(var1.Values);
                finalSortedList.Sort();

              
                var sortedListArray = finalSortedList.ToArray();
                var noOfItems = Double.Parse(TextBox1.Text);
                var sum = Double.Parse(TextBox2.Text);
                var sortObject = new Sort();
                var doubleResult = sortObject.FinalSort(noOfItems, sum, sortedListArray).ToArray();
                
                TextBox3.Text = "";
               
                foreach (double t in doubleResult)
                {
                   
                    var s = var1.ElementAt((var1.IndexOfValue(t))).ToString();
                    var sres = s.Split(',');
                    var tempInd = sres[1].IndexOf(']');
                    TextBox3.Text += "Item Name :" + sres[0].Substring(1) + " : $" +
                                     sres[1].Substring(0, tempInd) +
                                     Environment.NewLine + Environment.NewLine;
                    
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter digits in Both The fields ! Thank You ");
            }
        }
    }
}

    public class Items
    {
        public Double Price { get; set; }
        public string Name { get; set; }
    }

    public class Program
    {
        public SortedList<string, double> GiveList(String inputUrl)
        {
            var flag = false;
            var testString = 0.0;
           
            var sortedList = new SortedList<string, double>();
             string url = inputUrl;
                
            var request = WebRequest.Create(url);
            request.Method = "GET";
            var response = request.GetResponse();
            var dataStream = response.GetResponseStream();
            if (dataStream != null)
            {
                var reader = new StreamReader(dataStream);
                var responseFromServer = reader.ReadToEnd();

                var testReader = new JsonTextReader(new StringReader(responseFromServer));
                while (testReader.Read())
                {
                    if (testReader.Value != null)

                        if (testReader.TokenType == JsonToken.String)
                        {
                            if (flag)
                            {
                                if (sortedList.ContainsKey(testReader.Value.ToString()))
                                    flag = false;
                                else
                                {
                                    sortedList.Add(testReader.Value.ToString(), testString);
                                    flag = false;
                                }
                            }
                            else
                            {
                                flag = true;
                                var tempString = testReader.Value.ToString();
                                testString = double.Parse(tempString, NumberStyles.Currency);
                            }
                        }
                }
            }
            return sortedList;
        }
    }

    public class Sort
    {
        
        public ArrayList FinalSort(double noOfItems, double totalsum,double[] a )
	    {
		var h1 = new Hashtable();
		var count = noOfItems;
		double currentSum =0;
		int incr =1;
		var resultSet = new ArrayList();
            double lastTemp=0;
		int tempIndex=0;
		while(count!=0){
			
			
			double findSum = (totalsum/noOfItems)*incr;
			
			int left =0;
			int right = a.Length -1;
			int middle = (right- left )/2;


		    double temp;
		    if(currentSum + a[middle] > findSum){
				var savedIndex=0;
				
				while(currentSum + a[middle] > findSum && (right!=0 || left!=0)){
					savedIndex = middle +1;
					right = middle;
					middle = (right- left )/2;
				}
				
				if(right==0 ){
					
					while(true){
						if(!h1.ContainsKey(a[left]))
						{
							h1.Add(a[left],true);
							count--;
							resultSet.Add(a[left]);
							incr++;
							currentSum = currentSum + a[left];
							break;
						}
						else
							left++;
					}
					
				}
				
				else{
				while(left<=right){
					
					 temp = a[left]+ currentSum;
					
					if(Math.Abs(findSum - temp) < Math.Abs(findSum - lastTemp) && !h1.ContainsKey(a[left]) ) {
						
						lastTemp = temp;
						tempIndex = left;
						
					}
					left++;
				}
				
				if((Math.Abs(findSum - lastTemp) >Math.Abs (findSum - a[savedIndex])) && !h1.ContainsKey(a[savedIndex]) )
				{
					tempIndex = savedIndex;
					
				}
				
				resultSet.Add(a[tempIndex]);
				currentSum = currentSum + a[tempIndex];
				h1.Add(a[tempIndex], true);
				incr++;
				count--;
				
			}
		}
			
			else if(currentSum + a[middle] < findSum){
				
				
				while(left<=right){
					
					 temp = a[left]+ currentSum;
					if((Math.Abs(findSum - temp) <Math.Abs (findSum - lastTemp)) && !h1.Contains(a[left])) {
						lastTemp = temp;
						 tempIndex= left;
					}
					left++;
				}
				resultSet.Add(a[tempIndex]);
				currentSum = currentSum + a[tempIndex];
				h1.Add(a[tempIndex], true);
				incr++;
				count--;
				
			}
			
			
			
		}
		
		return resultSet;
	}


    }
}
