<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProgressionBuilder.aspx.cs" Inherits="ChordnomiconWebApplication.Pages.ProgressionBuilder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body { background-color:white; }

        .progressionButtons {
            float:left;
            width:8%;
            text-align:center;  
        }

        @media screen and (max-width: 800px) {
            .progressionButtons {   
                float:left;
                width:10%;
                text-align:center;;
            }
        }

        @media screen and (max-width: 400px) {
            .progressionButtons {   
                float:left;
                width:12%;
                text-align:center;;
            }
        }

        .progressionButtons button {
            background-color: white;
            color:black;
            margin:10px;
            border:5px;
            border-style:outset;
            padding:0px;
            width:80px;
        }

        .progressionButtons button:hover {
            background-color: #ddd;
            color: black;
        }

        .progression {
            float:right;
            width:92%;
        }

        @media screen and (max-width: 800px) {
            .progression {   
                float:left;
                width:90%;
                text-align:center;;
            }
        }

        @media screen and (max-width: 400px) {
            .progression {   
                float:left;
                width:88%;
                text-align:center;;
            }
        }

        .progressionOptions {
            overflow:auto;
            align-content:center;
        }

        .progressionOptions img {
            float:right;

        }

        .entryarea {
            padding:10px;
        }

        .entrysection {
            margin:20px;
        }


    </style>

    <script>
        function keyModeButton() {
            document.getElementById("keyAndMode").style.display = "block";
            document.getElementById("instrument").style.display = "none";
            document.getElementById("addChord").style.display = "none";
            document.getElementById("modifyChord").style.display = "none";
        }
        function instrumentButton() {
            document.getElementById("keyAndMode").style.display = "none";
            document.getElementById("instrument").style.display = "block";
            document.getElementById("addChord").style.display = "none";
            document.getElementById("modifyChord").style.display = "none";
        }
        function addChordButton() {
            document.getElementById("keyAndMode").style.display = "none";
            document.getElementById("instrument").style.display = "none";
            document.getElementById("addChord").style.display = "block";
            document.getElementById("modifyChord").style.display = "none";
        }
        function modifyChordButton() {
            document.getElementById("keyAndMode").style.display = "none";
            document.getElementById("instrument").style.display = "none";
            document.getElementById("addChord").style.display = "none";
            document.getElementById("modifyChord").style.display = "block";
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="progressionButtons">
            <button onclick="keyModeButton()">Change key<br />or mode</button>
            <button onclick="instrumentButton()">Change<br />instrument</button>
            <button onclick="addChordButton()">Add a<br />chord</button>
            <button onclick="modifyChordButton()">Modify a<br />chord</button>
            <button onclick="resetProgressionButton()">Reset<br />progression</button>
        </div>
        <div class="progression">
            <div class="progressionOptions">
                <asp:Image ID="ProgressionChromaticCircle" runat="server" Height="300px" Width="300px" AlternateText="Chromatic Circle" />
            
                <div class="entryarea" id="keyAndMode">
                    <div class="entrysection">
                        Please enter the key for your progression.<br />
                        Use the &#39;#&#39; (number sign) character for sharp and the<br />
                        &#39;b&#39; (lower case b) character for flat.<br />

                        <asp:TextBox ID="KeyEntryBox" runat="server" OnTextChanged="KeyEntryBox_TextChanged" style=""></asp:TextBox>

                        <asp:Button ID="KeyEntryButton" runat="server" OnClick="KeyEntryButton_Click" Text="Enter Key" />
                        <br />
                        <asp:Label ID="KeyEntryLabel" runat="server" Text="Enter a note" ForeColor="DarkRed"></asp:Label>
                    </div>
                    <div class="entrysection">
                        Please enter the mode for your progression.<br />

                        <asp:TextBox ID="ModeEntryBox" runat="server" OnTextChanged="ModeEntryBox_TextChanged" style=""></asp:TextBox>

                        <asp:Button ID="ModeEntryButton" runat="server" OnClick="ModeEntryButton_Click" Text="Enter Mode" />
                        <br />
                        <asp:Label ID="ModeEntryLabel" runat="server" Text="Enter a mode" ForeColor="DarkRed"></asp:Label>
                    </div>
                </div>

            </div>
            <asp:Image ID="Image1" runat="server" Height="300px" Width="300px" AlternateText="Chromatic Circle" />
        </div>
    </form>

    
</body>
</html>
