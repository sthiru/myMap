<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LocationHistory.aspx.cs" Inherits="MapsHistory.LocationHistory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <asp:FileUpload id="FileUploadControl" runat="server" />
                </td>
                <td>
                    <asp:Button runat="server" id="UploadButton" text="Upload" OnClick="UploadButton_Click"/>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblStatus" runat="server"></asp:Label>
                </td>
            </tr>
    
            </table>
    </div>
    </form>
</body>
</html>
