


using _02_9_Smells_Comments;


var y = new LinearInterpolator([1, 2, 3], [2, 4, 6]);


// 1000 zeilen später 
// ...
// ...


// yval is the value of y at x = 2.5
// y is a instance of LinearInterpolator
var yval = y.Interpolate(2.5);
