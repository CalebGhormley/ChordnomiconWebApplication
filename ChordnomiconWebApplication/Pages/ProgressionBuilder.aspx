<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProgressionBuilder.aspx.cs" Inherits="ChordnomiconWebApplication.Pages.ProgressionBuilder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body { 
            background-color:white;
            margin:0px;
            border:0px;
            padding:0px;
        }
        .prognav {
            overflow:hidden;
            display:block;
            margin:0px;
            text-align:center;
            background-color:black;
        }
        .prognav p {
            margin-left:auto;
            margin-right:auto;
            margin-bottom:5px;
            margin-top:5px;
            padding:0px;
            border:0px;
            display:block;
            color:white;
        }
        .prognav button {
            background-color:black;
            color:white;
            font-family:'Old English Text MT';
            text-decoration:underline;
            font-size:medium;
            border:0px;
            margin:0px;
            padding:5px;
        }

        .prognav button:hover {
            background-color: #ddd;
            color: black;
        }

        .progoptions {
            background-color:black;
            color:white;
            font-family:'Old English Text MT';
            text-decoration:underline;
            font-size:medium;
            border:0px;
            margin:0px;
            padding:5px;
        }

        .progoptions:hover {
            background-color: #ddd;
            color: black;
        }

        .imageoptions {
            font-family:'Old English Text MT';
            text-decoration:underline;
            font-size:medium;
            border:0px;
            margin:0px;
            padding:0px;
        }
        .chromaticImageWindow {
            width:25%;
            float:left;
            margin-top:0px;
            margin-bottom:0px;
            margin-left: auto;
            margin-right: auto;
            padding:0px;
        }
        .chromaticImageWindow image {
            display: block;
            margin-left: auto;
            margin-right: auto;
            margin-top:0px;
            margin-bottom:0px;
            padding:0px;
        }
        .progressionOptionsWindow {
            width:75%;
            float:left;
        }
        .tabOrSheetWindow {
            float:left;
            clear:left;
        }
        .tabAndSheet {
            overflow:auto;
            height:195px;
            width:520px; 
        }

        .leftoptions {
            margin-top:20px;
            font-weight:bold;
            width:50%;
            float:left;
        }
        .rightoptions {
            margin-top:20px;
            font-weight:bold;
            width:50%;
            float:right;
        }

        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="prognav">
                <p>
                    <asp:Button ID="keyOrModeOptions" runat="server" OnClick="keyOrModeOptions_Click" class="progoptions" Text="Change Key or Mode" />
                    <asp:Button ID="addChordOptions" runat="server" OnClick="addChordOptions_Click" class="progoptions" Text="Add a Chord" />
                    <asp:Button ID="modifyChordOptions" runat="server" OnClick="modifyChordOptions_Click" class="progoptions" Text="Modify a Chord" />
                    <asp:Button ID="modifyInstrumentOptions" runat="server" OnClick="modifyInstrumentOptions_Click" class="progoptions" Text="Change or Modify Instrument" />
                    <asp:Button ID="clearProgressionOtions" runat="server" OnClick="clearProgressionOtions_Click" class="progoptions" Text="Clear Progression" />
                </p>
        </div>

        <div class="chromaticImageWindow">
            <asp:Image ID="ProgressionChromaticCircle" runat="server" Height="250px" Width="250px" AlternateText="Chromatic Circle" />
        </div>

        <div class="progressionOptionsWindow">
            <div runat="server" id="keyOrMode">
                   <div class="leftoptions">
                        Please enter the key for your progression.<br />
                        Use the &#39;#&#39; (number sign) character for sharp and the<br />
                        &#39;b&#39; (lower case b) character for flat.<br />

                        <asp:TextBox ID="KeyEntryBox" runat="server" OnTextChanged="KeyEntryBox_TextChanged" style=""></asp:TextBox>

                        <asp:Button ID="KeyEntryButton" runat="server" OnClick="KeyEntryButton_Click" Text="Enter Key" />
                        <br />
                        <asp:Label ID="KeyEntryLabel" runat="server" Text="Enter a note" ForeColor="DarkRed"></asp:Label>
                    </div>
                    <div class="rightoptions">
                        Please enter the mode for your progression.<br />

                        <asp:TextBox ID="ModeEntryBox" runat="server" OnTextChanged="ModeEntryBox_TextChanged" style=""></asp:TextBox>

                        <asp:Button ID="ModeEntryButton" runat="server" OnClick="ModeEntryButton_Click" Text="Enter Mode" />
                        <br />
                        <asp:Label ID="ModeEntryLabel" runat="server" Text="Enter a mode" ForeColor="DarkRed"></asp:Label>
                    </div>
            </div>
            <div runat="server" id="addChord">
                <div class="leftoptions">
                        Please enter the chord you want to add to your progression.<br />
                        Use the &#39;#&#39; (number sign) character for sharp and the<br />
                        &#39;b&#39; (lower case b) character for flat.<br />

                        <asp:TextBox ID="ChordEntryBox" runat="server" OnTextChanged="ChordEntryBox_TextChanged" style=""></asp:TextBox>

                        <asp:Button ID="ChordEntryButton" runat="server" OnClick="ChordEntryButton_Click" Text="Enter Chord" />
                        <br />
                        <asp:Label ID="ChordEntryLabel" runat="server" Text="Enter a Chord" ForeColor="DarkRed"></asp:Label>
                        <br />
                </div>
                <div class="rightoptions">

                    <asp:DropDownList ID="DropDownList1" runat="server">
                    </asp:DropDownList>

                </div>
            </div>
            <div runat="server" id="modifyChord">
                <div class="leftoptions">

                </div>
                <div class="rightoptions">

                </div>
            </div>
            <div runat="server" id="modifyInstrument">
                <div class="leftoptions">
                    
                </div>
                <div class="rightoptions">

                </div>
            </div>
            <div runat="server" id="clearProgression">
                Are you sure you want to delete your current progression?
                <asp:Button ID="yesClearButton" runat="server" OnClick="yesClearButton_Click" Text="Yes" />
                <asp:Button ID="noClearButton" runat="server" OnClick="noClearButton_Click" Text="No" />
            </div>
        </div>

        <div class="tabOrSheetWindow">
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" BackColor="White" CssClass="imageoptions" Height="16px" RepeatDirection="Horizontal" Width="214px">
                <asp:ListItem Selected="True">Sheet Music</asp:ListItem>
                <asp:ListItem>Tablature</asp:ListItem>
            </asp:RadioButtonList>
            <asp:Image ID="ProgressionSheetMusic" class="tabAndSheet" runat="server" AlternateText="Sheet Music" />
        </div>

        
    </form>
</body>
</html>
