//            ScriptTextInput(string titleText,                     string labelText,                   string defaultInputBoxText, bool isMultiline)
String Text = ScriptTextInput("This is the form title.", "This is the label prompt.", "This is a single text line input box test.", false);
ScriptMessage(Text);
//     ScriptTextInput(string titleText,                     string labelText,                   string defaultInputBoxText,                                                                                              bool isMultiline)
Text = ScriptTextInput("This is the form title.", "This is the label prompt.", "This is the default value string in the text box.\r\nNotice how you can have multiple lines?\r\nNotice how you can have multiple lines?", true);
ScriptMessage(Text);