/*
 * Created by SharpDevelop.
 * User: Homka
 * Date: 13.11.2018
 * Time: 23:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PictureCode2
{
	/// <summary>
	/// Description of Functions.
	/// </summary>
	public class Functions
	{
		public Functions()
		{
		}
		
		public static String GetHexNumber(byte b)
		{
			String line;
			line = b < 16 ? "0x0" : "0x";
			return (line + Convert.ToString(b, 16));
		}
		
		public static byte SetBit(byte val, int num,bool bit)
		{
			if ((num> 7) || (num< 0))//Проверка входных данных
			{
			   throw new ArgumentException();
			}
			byte tmpval = 1;
			tmpval = (byte)(tmpval<<num);//устанавливаем нужный бит в единицу
			val = (byte)(val& (~tmpval));//сбрасываем в 0 нужный бит
			
			if (bit)// если бит требуется установить в 1
			{
			   val = (byte)(val | (tmpval));//то устанавливаем нужный бит в 1
			}
			return val;
		}
	}
}
