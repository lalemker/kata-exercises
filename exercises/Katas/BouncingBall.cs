using System;

namespace Katas;

public class BouncingBall
{

  public static int bouncingBall(double h, double bounce, double window) {
		// your code
    if (!(h > 0 && 0 < bounce && bounce < 1 && window < h)) return -1;

    var transitHeight = h;  //the drop
    var transits = 0;

    while (transitHeight >= window) {
      transits++;  //the fall sighting
      transitHeight *= bounce; //the bounce height
      if (transitHeight >= window) transits++; //the bounce sighting
    }

	  return transits;
	}
}
