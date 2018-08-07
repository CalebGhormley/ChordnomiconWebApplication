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
            width:100%;
            height:195px;
        }
        .tabAndSheet {
            overflow:scroll;
            width:100%;
            height:100%;
        }

        .leftoptions {
            margin-top:20px;
            width:50%;
            float:left;
        }
        .rightoptions {
            margin-top:20px;
            width:50%;
            float:right;
        }
        .centeroptions {
            margin-top:20px;
            width:50%;
        }
        .boldp {
            font-weight:bold;
            margin:0px;
        }
        .subp {
            margin:0px;
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
                        <p class="boldp">Enter key</p>
                        <p class="subp">b = flat, # = flat</p>

                        <asp:TextBox ID="KeyEntryBox" runat="server" OnTextChanged="KeyEntryBox_TextChanged" style=""></asp:TextBox>

                        <asp:Button ID="KeyEntryButton" runat="server" OnClick="KeyEntryButton_Click" Text="Enter Key" />
                        <br />
                        <asp:Label ID="KeyEntryLabel" runat="server" Text="" ForeColor="DarkRed"></asp:Label>
                        <br />
                        <p class="boldp">Or</p>
                        <p class="boldp">Select key</p>
                        &nbsp;<asp:DropDownList ID="KeyDropDownList" runat="server" OnSelectedIndexChanged="KeyDropDownList_SelectedIndexChanged">
                            <asp:ListItem Selected="True">-</asp:ListItem>
                            <asp:ListItem>Ab</asp:ListItem>
                            <asp:ListItem>A</asp:ListItem>
                            <asp:ListItem>A#</asp:ListItem>
                            <asp:ListItem>Bb</asp:ListItem>
                            <asp:ListItem>B</asp:ListItem>
                            <asp:ListItem>C</asp:ListItem>
                            <asp:ListItem>C#</asp:ListItem>
                            <asp:ListItem>Db</asp:ListItem>
                            <asp:ListItem>D</asp:ListItem>
                            <asp:ListItem>D#</asp:ListItem>
                            <asp:ListItem>Eb</asp:ListItem>
                            <asp:ListItem>E</asp:ListItem>
                            <asp:ListItem>F</asp:ListItem>
                            <asp:ListItem>F#</asp:ListItem>
                            <asp:ListItem>Gb</asp:ListItem>
                            <asp:ListItem>G</asp:ListItem>
                            <asp:ListItem>G#</asp:ListItem>
                        </asp:DropDownList>
                       <asp:Button ID="KeyEntryDropdownButton" runat="server" OnClick="KeyEntryDropdownButton_Click" Text="Enter Key" />
                        <br />
                    </div>
                    <div class="rightoptions">
                        <p class="boldp">Enter mode</p>
                        <asp:TextBox ID="ModeEntryBox" runat="server" OnTextChanged="ModeEntryBox_TextChanged" style=""></asp:TextBox>

                        <asp:Button ID="ModeEntryButton" runat="server" OnClick="ModeEntryButton_Click" Text="Enter Mode" />
                        <br />
                        <asp:Label ID="ModeEntryLabel" runat="server" Text="" ForeColor="DarkRed"></asp:Label>
                        <br />
                        <p class="boldp">Or</p>
                        <p class="boldp">Select mode</p>
                        <p class="subp">Select mode type</p>
                        <asp:DropDownList ID="ModeToneDropDownList" runat="server" OnSelectedIndexChanged="ModeToneDropDownList_SelectedIndexChanged">
                            <asp:ListItem>Pentatonic</asp:ListItem>
                            <asp:ListItem>Hexatonic</asp:ListItem>
                            <asp:ListItem Selected="True">Heptatonic</asp:ListItem>
                            <asp:ListItem>Heptatonic Alternative</asp:ListItem>
                            <asp:ListItem>Octotonic</asp:ListItem>
                        </asp:DropDownList>
                        <asp:Button ID="ModeTypeButton" runat="server" OnClick="ModeTypeButton_Click" Text="Enter Mode Type" />
                        <br />
                        <br />
                        <p class="subp">Select mode</p>
                        <div runat="server" id="pentatonicModes">
                            <asp:DropDownList ID="PentatonicDropDownList" runat="server" OnSelectedIndexChanged="PentatonicDropDownList_SelectedIndexChanged">
                                <asp:ListItem>Blues Major</asp:ListItem>
                                <asp:ListItem>Pentatonic Major</asp:ListItem>
                                <asp:ListItem>Suspended</asp:ListItem>
                                <asp:ListItem>Pentatonic Minor</asp:ListItem>
                                <asp:ListItem>Blues Minor</asp:ListItem>
                                <asp:ListItem>Hirajoshi</asp:ListItem>
                                <asp:ListItem>In</asp:ListItem>
                                <asp:ListItem>Iwato</asp:ListItem>
                                <asp:ListItem>Insen</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Button ID="PentatonicModeDropDownButton" runat="server" OnClick="PentatonicModeDropDownEntryButton_Click" Text="Enter Mode" />
                        </div>

                        <div runat="server" id="hexatonicModes">
                            <asp:DropDownList ID="HexatonicDropDownList" runat="server" OnSelectedIndexChanged="HexatonicDropDownList_SelectedIndexChanged">
                                <asp:ListItem>Blues</asp:ListItem>
                                <asp:ListItem>Whole Tone</asp:ListItem>
                                <asp:ListItem>Augmented</asp:ListItem>
                                <asp:ListItem>Hexatonic Diminished</asp:ListItem>
                                <asp:ListItem>Tritone</asp:ListItem>
                                <asp:ListItem>Prometheus</asp:ListItem>
                                <asp:ListItem>Istran</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Button ID="HexatonicModeDropDownButton" runat="server" OnClick="HexatonicModeDropDownEntryButton_Click" Text="Enter Mode" />
                        </div>

                        <div runat="server" id="heptatonicModes">
                            <asp:DropDownList ID="HeptatonicDropDownList" runat="server" OnSelectedIndexChanged="HeptatonicDropDownList_SelectedIndexChanged">
                                <asp:ListItem>Lydian</asp:ListItem>
                                <asp:ListItem Selected="True">Ionian (Major)</asp:ListItem>
                                <asp:ListItem>Mixolydian</asp:ListItem>
                                <asp:ListItem>Dorian</asp:ListItem>
                                <asp:ListItem>Aeolian (Minor)</asp:ListItem>
                                <asp:ListItem>Phrygian</asp:ListItem>
                                <asp:ListItem>Locrian</asp:ListItem>
                                <asp:ListItem>Lydian Augmented</asp:ListItem>
                                <asp:ListItem>Lydian Flat-Seven</asp:ListItem>
                                <asp:ListItem>Harmonic Mixolydian</asp:ListItem>
                                <asp:ListItem>Half Diminished</asp:ListItem>
                                <asp:ListItem>Altered</asp:ListItem>
                                <asp:ListItem>Melodic Minor</asp:ListItem>
                                <asp:ListItem>Harmonic Phrygian</asp:ListItem>
                            </asp:DropDownList>
                        <asp:Button ID="HeptatonicModeDropDownButton" runat="server" OnClick="HeptatonicModeDropDownEntryButton_Click" Text="Enter Mode" />
                        </div>

                        <div runat="server" id="heptatonicAlternativeModes">
                            <asp:DropDownList ID="HeptatonicAlternativeDropDownList" runat="server" OnSelectedIndexChanged="HeptatonicAlternativeDropDownList_SelectedIndexChanged">
                                <asp:ListItem>Neapolitan Major</asp:ListItem>
                                <asp:ListItem>Super Augmented</asp:ListItem>
                                <asp:ListItem>Mixolydian Augmented</asp:ListItem>
                                <asp:ListItem>Minor Lydian</asp:ListItem>
                                <asp:ListItem>Major Locrian</asp:ListItem>
                                <asp:ListItem>Aeolian Diminished</asp:ListItem>
                                <asp:ListItem>Super Diminished</asp:ListItem>
                                <asp:ListItem>Hungarian Minor</asp:ListItem>
                                <asp:ListItem>Double Harmonic</asp:ListItem>
                                <asp:ListItem>Harmonic Minor</asp:ListItem>
                                <asp:ListItem>Pfluke</asp:ListItem>
                                <asp:ListItem>Neapolitan Minor</asp:ListItem>
                                <asp:ListItem>Enigmatic</asp:ListItem>
                                <asp:ListItem>Persian</asp:ListItem>
                                <asp:ListItem>Blues with Flat-Four</asp:ListItem>
                            </asp:DropDownList>
                        <asp:Button ID="HeptatonicAlternativeModeDropDownEntryButton" runat="server" OnClick="HeptatonicAlternativeModeDropDownEntryButton_Click" Text="Enter Mode" />
                        </div>

                        <div runat="server" id="octatonicModes">
                            <asp:DropDownList ID="OctatonicDropDownList" runat="server" OnSelectedIndexChanged="OctsatonicDropDownList_SelectedIndexChanged">
                                <asp:ListItem>Diminished Whole-Half</asp:ListItem>
                                <asp:ListItem>Diminished Half-Whole</asp:ListItem>
                                <asp:ListItem>Major Bebop</asp:ListItem>
                                <asp:ListItem>Bebop Dominant</asp:ListItem>
                            </asp:DropDownList>
                        <asp:Button ID="OctatonicModeDropDownButton" runat="server" OnClick="OctatonicModeDropDownEntryButton_Click" Text="Enter Mode" />
                        </div>
                    </div>
            </div>
            <div runat="server" id="addChord">
                <div class="leftoptions">
                        <p class="boldp">Enter chord</p>
                        <p class="subp">b = flat, # = sharp</p>

                        <asp:TextBox ID="ChordEntryBox" runat="server" OnTextChanged="ChordEntryBox_TextChanged" style=""></asp:TextBox>

                        <asp:Button ID="ChordEntryButton" runat="server" OnClick="ChordEntryButton_Click" Text="Enter Chord" />
                        <br />
                        <asp:Label ID="ChordEntryLabel" runat="server" Text="" ForeColor="DarkRed"></asp:Label>
                        <br />
                </div>
                <div class="rightoptions">
                    Recommended Chords
                    <br />
                    <asp:DropDownList ID="RecommendedChordsDropDownList" runat="server" OnSelectedIndexChanged="RecommendedChordsDropDownList_SelectedIndexChanged">
                    </asp:DropDownList>

                </div>
            </div>
            <div runat="server" id="modifyChord">
                <div class="leftoptions">
                    <p class="boldp">Remove a Chord</p>
                    <asp:DropDownList ID="RemoveChordDropDownList" runat="server" OnSelectedIndexChanged="RemoveChordDropDownList_SelectedIndexChanged">
                        <asp:ListItem Value="0">-</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Button ID="RemoveChordButton" runat="server" OnClick="RemoveChordButton_Click" Text="Remove Chord"/>
                    <br />
                    <br />
                    <p class="boldp">Replace a Chord</p>
                    <p class="subp">Select a chord to replace</p>
                    <asp:DropDownList ID="ReplaceChordDropDownList" runat="server" OnSelectedIndexChanged="ReplaceChordDropDownList_SelectedIndexChanged">
                        <asp:ListItem Selected="True">-</asp:ListItem>
                    </asp:DropDownList><br />
                    <p class="subp">Enter a chord to replace the selected chord</p>
                    <asp:TextBox ID="ReplaceChordTextBox" runat="server" OnTextChanged="ReplaceChordEntryBox_TextChanged" style=""></asp:TextBox>
                    <asp:Button ID="ReplaceChordButton" runat="server" OnClick="ReplaceChordEntryButton_Click" Text="Replace Chord" />
                    <br />
                    <asp:Label ID="ReplaceChordLabel" runat="server" Text="" ForeColor="DarkRed"></asp:Label>
                    <br />
                </div>
                <div class="rightoptions">
                    <p class="boldp">Switch two Chords</p>
                    <asp:DropDownList ID="SwitchFirstChordDropDownList" runat="server" OnSelectedIndexChanged="SwitchFirstChordDropDownList_SelectedIndexChanged">
                        <asp:ListItem Value="0">-</asp:ListItem>
                    </asp:DropDownList><br />
                    <asp:DropDownList ID="SwitchSecondDropDownList" runat="server" OnSelectedIndexChanged="SwitchSecondDropDownList_SelectedIndexChanged">
                        <asp:ListItem Value="0">-</asp:ListItem>
                    </asp:DropDownList><br />
                    <asp:Button ID="SwitchChordsButton" runat="server" OnClick="SwitchChordsButton_Click" Text="Switch Chords" />
                    <br />
                    <asp:Label ID="SwitchChordsLabel" runat="server" Text="" ForeColor="DarkRed"></asp:Label>
                    <br />
                    <br />
                    <p class="boldp">Change the voicing of a chord</p> 
                    <p class="subp">Select the chord to alter</p>
                    <asp:DropDownList ID="ShiftChordDropDownList" runat="server" OnSelectedIndexChanged="ShiftChordDropDownList_SelectedIndexChanged">
                        <asp:ListItem>-</asp:ListItem>
                    </asp:DropDownList><br />
                    <asp:Button ID="ShiftChordLeftButton" runat="server" OnClick="ShiftChordLeftButton_Click" Text="Shift Left" />
                    <br />
                    <asp:Button ID="ShiftChordRightButton" runat="server" OnClick="ShiftChordRightButton_Click" Text="Shift Right" />
                    <br />
                    <asp:Label ID="ModifyVoicingLabel" runat="server" Text="" ForeColor="DarkRed"></asp:Label>
                    <br />
                </div>
            </div>
            <div runat="server" id="modifyInstrument">
                <div class="leftoptions">
                    <p class="boldp">Change Instrument</p>
                    <asp:DropDownList ID="InstrumentDrowDownList" runat="server" OnSelectedIndexChanged="InstrumentDrowDownList_SelectedIndexChanged">
                        <asp:ListItem Selected="True">Guitar</asp:ListItem>
                        <asp:ListItem>Bass</asp:ListItem>
                        <asp:ListItem>Ukulele</asp:ListItem>
                        <asp:ListItem>Banjo</asp:ListItem>
                        <asp:ListItem>Mandolin</asp:ListItem>
                        <asp:ListItem>Piano</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Button ID="ChangeInstrumentButton" runat="server" OnClick="ChangeInstrumentButton_Click" Text="Enter Instrument" />
                </div>
                <div class="rightoptions">
                    <div runat="server" id="stringedInstrumentTunning">
                        <div class="leftoptions">
                            <p class="boldp">Change tunning</p>
                            <p class="subp">First String</p>
                            <asp:DropDownList ID="FirstStringDropDownList" runat="server" OnSelectedIndexChanged="FirstStringDropDownList_SelectedIndexChanged">
                            <asp:ListItem>Ab</asp:ListItem>
                            <asp:ListItem>A</asp:ListItem>
                            <asp:ListItem>A#</asp:ListItem>
                            <asp:ListItem>Bb</asp:ListItem>
                            <asp:ListItem>B</asp:ListItem>
                            <asp:ListItem>C</asp:ListItem>
                            <asp:ListItem>C#</asp:ListItem>
                            <asp:ListItem>Db</asp:ListItem>
                            <asp:ListItem>D</asp:ListItem>
                            <asp:ListItem>D#</asp:ListItem>
                            <asp:ListItem>Eb</asp:ListItem>
                            <asp:ListItem Selected="True">E</asp:ListItem>
                            <asp:ListItem>F</asp:ListItem>
                            <asp:ListItem>F#</asp:ListItem>
                            <asp:ListItem>Gb</asp:ListItem>
                            <asp:ListItem>G</asp:ListItem>
                            <asp:ListItem>G#</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                            <p class="subp">Second String</p>
                            <asp:DropDownList ID="SecondStringDropDownList" runat="server" OnSelectedIndexChanged="SecondStringDropDownList_SelectedIndexChanged">
                            <asp:ListItem>Ab</asp:ListItem>
                            <asp:ListItem>A</asp:ListItem>
                            <asp:ListItem>A#</asp:ListItem>
                            <asp:ListItem>Bb</asp:ListItem>
                            <asp:ListItem Selected="True">B</asp:ListItem>
                            <asp:ListItem>C</asp:ListItem>
                            <asp:ListItem>C#</asp:ListItem>
                            <asp:ListItem>Db</asp:ListItem>
                            <asp:ListItem>D</asp:ListItem>
                            <asp:ListItem>D#</asp:ListItem>
                            <asp:ListItem>Eb</asp:ListItem>
                            <asp:ListItem>E</asp:ListItem>
                            <asp:ListItem>F</asp:ListItem>
                            <asp:ListItem>F#</asp:ListItem>
                            <asp:ListItem>Gb</asp:ListItem>
                            <asp:ListItem>G</asp:ListItem>
                            <asp:ListItem>G#</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                            <p class="subp">Third String</p>
                            <asp:DropDownList ID="ThirdStringDropDownList" runat="server" OnSelectedIndexChanged="ThirdStringDropDownList_SelectedIndexChanged">
                            <asp:ListItem>Ab</asp:ListItem>
                            <asp:ListItem>A</asp:ListItem>
                            <asp:ListItem>A#</asp:ListItem>
                            <asp:ListItem>Bb</asp:ListItem>
                            <asp:ListItem>B</asp:ListItem>
                            <asp:ListItem>C</asp:ListItem>
                            <asp:ListItem>C#</asp:ListItem>
                            <asp:ListItem>Db</asp:ListItem>
                            <asp:ListItem>D</asp:ListItem>
                            <asp:ListItem>D#</asp:ListItem>
                            <asp:ListItem>Eb</asp:ListItem>
                            <asp:ListItem>E</asp:ListItem>
                            <asp:ListItem>F</asp:ListItem>
                            <asp:ListItem>F#</asp:ListItem>
                            <asp:ListItem>Gb</asp:ListItem>
                            <asp:ListItem Selected="True">G</asp:ListItem>
                            <asp:ListItem>G#</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                        </div>
                        <div class="rightoptions">
                        <br />
                            <p class="subp">Fourth String</p>
                            <asp:DropDownList ID="FourthStringDropDownList" runat="server" OnSelectedIndexChanged="FourthStringDropDownList_SelectedIndexChanged">
                            <asp:ListItem>Ab</asp:ListItem>
                            <asp:ListItem>A</asp:ListItem>
                            <asp:ListItem>A#</asp:ListItem>
                            <asp:ListItem>Bb</asp:ListItem>
                            <asp:ListItem>B</asp:ListItem>
                            <asp:ListItem>C</asp:ListItem>
                            <asp:ListItem>C#</asp:ListItem>
                            <asp:ListItem>Db</asp:ListItem>
                            <asp:ListItem Selected="True">D</asp:ListItem>
                            <asp:ListItem>D#</asp:ListItem>
                            <asp:ListItem>Eb</asp:ListItem>
                            <asp:ListItem>E</asp:ListItem>
                            <asp:ListItem>F</asp:ListItem>
                            <asp:ListItem>F#</asp:ListItem>
                            <asp:ListItem>Gb</asp:ListItem>
                            <asp:ListItem>G</asp:ListItem>
                            <asp:ListItem>G#</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                            <p class="subp">Fifth String</p>
                            <asp:DropDownList ID="FifthStringDropDownList" runat="server" OnSelectedIndexChanged="FifthStringDropDownList_SelectedIndexChanged">
                            <asp:ListItem>Ab</asp:ListItem>
                            <asp:ListItem Selected="True">A</asp:ListItem>
                            <asp:ListItem>A#</asp:ListItem>
                            <asp:ListItem>Bb</asp:ListItem>
                            <asp:ListItem>B</asp:ListItem>
                            <asp:ListItem>C</asp:ListItem>
                            <asp:ListItem>C#</asp:ListItem>
                            <asp:ListItem>Db</asp:ListItem>
                            <asp:ListItem>D</asp:ListItem>
                            <asp:ListItem>D#</asp:ListItem>
                            <asp:ListItem>Eb</asp:ListItem>
                            <asp:ListItem>E</asp:ListItem>
                            <asp:ListItem>F</asp:ListItem>
                            <asp:ListItem>F#</asp:ListItem>
                            <asp:ListItem>Gb</asp:ListItem>
                            <asp:ListItem>G</asp:ListItem>
                            <asp:ListItem>G#</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                            <p class="subp">Sixth String</p>
                        <asp:DropDownList ID="SixthStringDropDownList" runat="server" OnSelectedIndexChanged="SixthStringDropDownList_SelectedIndexChanged">
                            <asp:ListItem>Ab</asp:ListItem>
                            <asp:ListItem>A</asp:ListItem>
                            <asp:ListItem>A#</asp:ListItem>
                            <asp:ListItem>Bb</asp:ListItem>
                            <asp:ListItem>B</asp:ListItem>
                            <asp:ListItem>C</asp:ListItem>
                            <asp:ListItem>C#</asp:ListItem>
                            <asp:ListItem>Db</asp:ListItem>
                            <asp:ListItem>D</asp:ListItem>
                            <asp:ListItem>D#</asp:ListItem>
                            <asp:ListItem>Eb</asp:ListItem>
                            <asp:ListItem Selected="True">E</asp:ListItem>
                            <asp:ListItem>F</asp:ListItem>
                            <asp:ListItem>F#</asp:ListItem>
                            <asp:ListItem>Gb</asp:ListItem>
                            <asp:ListItem>G</asp:ListItem>
                            <asp:ListItem>G#</asp:ListItem>
                        </asp:DropDownList>
                        </div>
                        <asp:Button ID="ChangeTunningButton" runat="server" OnClick="ChangeTunningButton_Click" Text="Enter Tunning" />
                        <br />
                        <asp:Label ID="ChangeTunningLabel" runat="server" Text="" ForeColor="DarkRed"></asp:Label>
                    </div>
                </div>
            </div>
            <div runat="server" id="clearProgression">
                <div class="centeroptions">
                Are you sure you want to delete your current progression?<br />
                &nbsp;<asp:Button ID="yesClearButton" runat="server" OnClick="yesClearButton_Click" Text="Yes" />
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="noClearButton" runat="server" OnClick="noClearButton_Click" Text="No" />
                </div>
            </div>
        </div>

        <div class="tabOrSheetWindow">
            <asp:RadioButtonList ID="RadioButtonTabOrSheet" runat="server" OnSelectedIndexChanged="RadioButtonTabOrSheet_SelectedIndexChanged" BackColor="White" CssClass="imageoptions" Height="16px" RepeatDirection="Horizontal" Width="214px" AutoPostBack="True">
                <asp:ListItem Selected="True" Value="0">Sheet Music</asp:ListItem>
                <asp:ListItem Value="1">Tablature</asp:ListItem>
            </asp:RadioButtonList>
            <asp:Image ID="ProgressionSheetMusic" class="tabAndSheet" runat="server" AlternateText="Sheet Music Or Tablature" />
        </div>

        
    </form>
</body>
</html>
