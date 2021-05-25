# Recursive_Path_Validity_Challenge

Recursive path validity. The purpose of this challange is to determine whether you can walk from one coordinate (x1, y1) to another (x2, y2).
However you cannot take any path, only two paths are available from each coordinate, which are (x, x+y) or (x+y, y).

Example:
	Startpoint (x1, y1) = (2,10)
	Endpoint (x2, y2) = (26,12)
	
	Is it possible to reach the end point? The answer is yes, because a valid path can be found like so:
	(2, 10) => (2, 12) => (14,12) => (26,12)

The method has to determine if there is a valid route between the start and endpoint. You may NOT use static variables, you can assume all coordinates to be positive.

The method signature should look as follows: 
public static boolean isRoute(int xStart, int yStart, int xEnd, int yEnd)

