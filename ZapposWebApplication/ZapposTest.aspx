<%@ Page Language="C#" AutoEventWireup="true"  CodeBehind="ZapposTest.aspx.cs" Inherits="ZapposWebApplication.ZapposTest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">


<body bgcolor="#E6E6FB" >
<form id="form1" runat="server">
<header >
<style>
h1 {border:1px solid black;
padding:35px;
background-image:url("http://upload.wikimedia.org/wikipedia/en/8/82/Zappos_logo_color.jpg");
background-repeat:no-repeat;
background-position:left;
}

</style>
<h1 font size="6" style="text-align: center;">Zappos Test Application </h1>
</header>
<br />
<br />
<br />
<br />

<font size="3" color="red"> Number Of Items: </font>&nbsp;
        <asp:TextBox ID="TextBox1" BorderColor="black" runat="server" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
&nbsp;&nbsp;<font size="3" color="red"> Total Cost :</font>
        <asp:TextBox ID="TextBox2" BorderColor="black" runat="server" ontextchanged="TextBox2_TextChanged"></asp:TextBox>
&nbsp;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server"  Height="28px" onclick="Button1_Click" 
    Text="Get Best Fit !" Width="112px"/>
        &nbsp;&nbsp;
<asp:Button ID="Button2" runat="server" Height="28px" onclick="Button2_Click" 
    Text="Get Lower Cost Products ?" Width="166px" />
        &nbsp;
<asp:Button ID="Button3" runat="server" onclick="Button3_Click" Height="28px" 
    Text="Click for Expensive Products !" Width="186px" />
        &nbsp;&nbsp;&nbsp;<br />
&nbsp;
<br />
   <style>
p{
    background: #E6E6FB;
    font-size: 20px;
    font-family: "Helvetica Neue", "Lucida Grande", "Segoe UI", Arial, Helvetica, Verdana, sans-serif;
    margin: 0px;
    padding: 0px;
    color: #696969;
}
</style>
<p font="4" align="center" >The 'Get Best Fit!' ButtonClick Event provides the "new" Gifts (items advertised in last 14 days*) for the given cost and number of Items. If you wish to choose from lower budget gifts(<$15) please use the 'Get Lower Cost Products ?' button. For expensive gifts(>$300) you may use the 'Click for Expensive Products !' button. </p>
<br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
       <font size="4" color="red"> Here Is the List Of Items For Your Cost :</font><br />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" TextMode="MultiLine" BorderColor="black" 
        BackColor="white" BorderWidth="4" runat="server" 
            ontextchanged="TextBox3_TextChanged" Height="204px" Width="671px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
<br />
    &nbsp;<p>The Zappos Image is retrieved from <a href="http://upload.wikimedia.org/wikipedia/en/8/82/Zappos_logo_color.jpg">Link To Image</a><br/><a href="AboutDeveloper.aspx">About the Developer</a> </p>
<br />
* as suggested by Zappos search API<br />
        <br />
        </form>
</body>
</html>
