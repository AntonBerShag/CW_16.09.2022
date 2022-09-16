// See https://aka.ms/new-console-template for more information
using CW_16._09._2022;


var myCircrle = new Circle();
MyDelegate _delegate = myCircrle.PrintSquare;
myCircrle.PrintName();
myCircrle._radius = 3f;
myCircrle.name = "Круг";
myCircrle.PrintName();
/*myCircrle.PrintSquare();
myCircrle.PrintSquare(true);*/
_delegate?.Invoke();
_delegate += myCircrle.WriteSqaare;
_delegate?.Invoke();
_delegate -= myCircrle.WriteSqaare;
_delegate?.Invoke();
_delegate += myCircrle.PrintSquare;
_delegate?.Invoke();