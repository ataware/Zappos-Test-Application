<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AboutDeveloper.aspx.cs" Inherits="ZapposWebApplication.AboutDeveloper" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <center> <h1 >About the Developer</h1></center>
    <title></title>
</head>
<body>Developer&#39;s Name: Atreya Parag Taware.<br />
    Atreya is a Graduate student at the Arizona State University. He is pursuing his Masters 
    Degree in field of Computer Science.His areas of interest are software development and web application development. 
    Enjoys working in a fun team environment and is eager to learn new technologies.
    <form id="form1" runat="server">
    <div>
    
        About the Application:
        <br />
        The application takes two inputs: the number of items(X) and total cost(Y), and 
        provides a list of items (equal to X) whose total cost is approximately equal to 
        Y. It uses the Zappos search API to get the list of items. The JSON response is 
        parsed using Json.Net which is a JSON framework for 
        .NET.(<a href="http://james.newtonking.com/json">James Newton-King</a>) The application pulls the recent items (using the isNew Facet), the expensive items(using sort=desc clause) and the loewr budget items(using sort = asc clause).
        It uses algorithm that is similar to subset sum problem to provide an estimate of the items and the total cost. It is a basic application to provide a solution to the given problem.</div>
        <p>Other projects by the developer:&nbsp; <br/>Web Service (WCF and .asmx) & Web Application Development&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;					Fall 2013<br/>
•	Developed SOAP based Web Services and RESTful services.  <br/>
•	Consumed online and developed web services to create ASP.NET web application with consideration of end user experience (GUI development using HTML and CSS).<br/>
•	Integration of Web Application of each member of group into a single Web Application (Travel Web Application) followed by deployment in the WebStrar server.<br/>
•	Project Link : http://webstrar4.fulton.asu.edu/ <br/>
•	Programming language and technologies used : C#,JSON, XML based technologies such as DOM, SAX, XPATH, XSLT and HTML, CSS <br/>
   Twitter Data Analysis&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Fall 2013<br/>
•	Implementing JAVA code and using twitter API to crawl Twitter users (BFS algorithm)<br/>
•	Analyzing the data collected using Gephi (0.8.2 Beta) to obtain power law distribution, centrality measures and Network Models.<br/>
Rudimentary compiler&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;										Fall 2013<br/>
•	Developing a semantic checker for a well defined grammar. Implementing a data structure (symbol table) to parse the input.<br/>
•	Developing working code for performing basic calculations for given input and thus developing rudimentary compiler. <br/>
•	Programming language used: C<br/>
SplitExpense Application<br/>
•	Developed a Desktop application using Java (GUI using Swing) to calculate and store expenses.<br/>
•	Connected the application to server database using XAMP server (using JDBC connector). Queries to MySQL database were carried out using Java.<br/>

    <p>&nbsp;<a href="ZapposTest.aspx">Go Back To Application</a></p></form>
</body>
</html>
