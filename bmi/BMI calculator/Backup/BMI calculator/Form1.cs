using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;                        // these import certain methods to be used in code program did it all for me
using System.Linq;
using System.Text;
using System.Windows.Forms;
///////////////////////////////////////////////THE IMPORTS///////////////////////////////////////////////////////////////////////

namespace BMI_calculator{ // name of application chosen in MV c#

public partial class BMICalculator : Form{ // called partial form becuase the rest of the code is hidden in designer.cs
    
public BMICalculator(){ // title of form1.cs
       InitializeComponent();
}
////////////////////////////////////////////THE FORMS//////////////////////////////////////////////////////////////////////
bool metric = true; // used to convert between metric and impearial 
double height; // saves the height entered
double weight; // saves the weight entered
double answer; // saves the answer 
int convertCount = 0; // used for when the button is pressed more than once 
////////////////////////////////////////////THE VARIABLES///////////////////////////////////////////////////////////////////////
        
private void resetbutton_Click(object sender, EventArgs e){
if (metric == false){
    weightbox.Text = "Pounds";
    heightbox.Text = "Inches";  // shows the units to be entered in
}
else if (metric == true){
weightbox.Text = "KG";  // shows the units to be entered in
heightbox.Text = "Meter";
}
bmibox.Text = "0";
height = 0.0;            // clears everything and resets it to default
weight = 0.0;
answer = 0;
} // end void

private void calculate_Click(object sender, EventArgs e){
height = double.Parse(heightbox.Text);    // saves what was entered in the box under height var
weight = double.Parse(weightbox.Text);   // saves what was entered in the box under weight var

if(metric == true){
   answer = weight / (height * height);    // calculates the answer
}
else if (metric == false){
         answer = weight / (height * height)* 703;    // calculates the answer
}

bmibox.Text = answer.ToString();  // shows answer in text box
} // end void

private void convertbutton_Click(object sender, EventArgs e){
if (convertCount == 0){  // button hasnt been pressed before
    metric = false;  // convert to impearlial
    converting(); // start the function
}
else if (convertCount == 1){ // button has been pressed before 
         metric = true; // convert back to metric
         converting(); // start function
         convertCount = 0; // reset the buttons use
}}// end void

private void converting(){ // used to convert between metric and impearial
if (metric == false){
    height *= 39.370078; //converts
    weight *= 2.20462;
    answer = weight / (height * height) * 703;
    heightbox.Text = height.ToString();  // shows converts in window boxes
    weightbox.Text = weight.ToString();
    bmibox.Text = answer.ToString();
    convertCount++; // convert button has been pressed
}
else if (metric == true){
         height *= 0.0254;
         weight *= 0.453592;       // converts
         answer = weight / (height * height);
         heightbox.Text = height.ToString();
         weightbox.Text = weight.ToString();  // shows converts in window
         bmibox.Text = answer.ToString();
}}// end void   
}} // end form


