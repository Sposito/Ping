using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
/// <summary>
/// Class with static mathods to create Color objects from hexadecimal formated strings
/// </summary>
public class HexColor:MonoBehaviour {

	public  HexColor(string hex){
		hex.ToUpper ();
		float r;
		float g;
		float b;
	
	}

	public static Color ToColor(string hex){
		hex.ToUpper ();

		float r = hexToFloat(hex.Substring(0,2)) / 255f;
		float g = hexToFloat(hex.Substring(2,2)) / 255f;
		float b = hexToFloat(hex.Substring(4,2)) / 255f;

		return new Color(r,g,b);

	}

	/// <summary>Convert a hexadecimal string into a float</summary>
	public static float hexToFloat(string hex){
		Dictionary<char, int> HexValues = new Dictionary<char, int> () {
			{ '0',  0 }, { '1',  1 }, { '2',  2 }, { '3',  3 }, { '4',  4 }, { '5',  5 }, { '6',  6 }, { '7',  7 },
			{ '8',  8 }, { '9',  9 }, { 'A', 10 }, { 'B', 11 }, { 'C', 12 }, { 'D', 13 }, { 'E', 14 }, { 'F', 15 }
		};

		double num = 0;
		string reverse = Reverse (hex);

		for (int i = 0; i < hex.Length; i++) {
			int iValue = HexValues [reverse [i]];
			num += Math.Pow ((double)16,(double) i) * iValue;
		}

		return (float)num;
	}

	public static string Reverse( string s )
	{
		char[] charArray = s.ToCharArray();
		Array.Reverse( charArray );
		return new string( charArray );
	}
		
}
