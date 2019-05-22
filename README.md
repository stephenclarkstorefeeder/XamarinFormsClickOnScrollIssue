# XamarinFormsClickOnScrollIssue
Reproduction repo for a click after scroll issue with Xamarin Forms

Displays a simple view containing 5 buttons in a scrollview. The click event on a button is not fired if scrolling at more than a smooth speed, eg swipe the view quickly to scroll to the bottom button and click it - the click is not heard. If you scroll down and wait a few seconds then the click is heard, or scroll down and tap the button twice quickly.

I would expect the button click to work as soon as scrolling reached the bottom and not need to wait a few seconds. 
