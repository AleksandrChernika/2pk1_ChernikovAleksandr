/*
 * Created by SharpDevelop.
 * User: alexo
 * Date: 09.05.2023
 * Time: 15:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace pz_27
{
	public struct AEROFLOT
	{
		public string NAZN;
		public int NUMR;
		public string TIP;
		public AEROFLOT(string NAZN, int NUMR, string TIP)
		{
			this.NAZN = NAZN;
			this.NUMR = NUMR;
			this.TIP = TIP;
		}
	}
}
