/*
 * Created by SharpDevelop.
 * User: Ndaru
 * Date: 11/05/2013
 * Time: 23:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace VigènereChipher
{
	/// <summary>
	/// Description of cod.
	/// </summary>
	public class cod {
		
		private int [] dataP;
		private int [] dataK;
		private int [] dataH;
		private string [] alfabet;
		public string plain = "",kunci = "";
		
		public void SetAlfabet(){
			alfabet = new string[26];			
			int n=0;
			for (char i='A'; i<='Z'; i++) {
				alfabet[n]=i.ToString();
				n++;
			}				
		}
		public void ResumeAlfabet(){
			for (int i=0; i<alfabet.Length; i++) {
				Console.Write(alfabet[i]+"="+i.ToString()+" | ");
			}
			Console.WriteLine();
		
		}
		public void InputPlaiNSet(){
			
			Console.Write("set Plaintext \t= ");
			plain = SetPlainNKunci();	
			dataP = new int[plain.Length];
			dataK = new int[plain.Length];
			
			int n = 0;
			bool error ;
			for (int i=0; i<plain.Length; i++) {
				string pecah = plain.Substring(n,1);
				error = true;
				for (int j=0; j<26; j++) {
					if (alfabet[j].Equals(pecah.ToString())) {
						dataP[i]=j;	
						n+=1;
						if (n==plain.Length) {
							n=0;			
						}
						error = false;
						
					}
										
				}					
				if (error) {
					Console.WriteLine(pecah+" => else");
					Console.WriteLine("harus huruf bro !!!!");
					InputPlaiNSet();
					break;
				}
				
			}
		}
		public void InputKunciNSet(){
			Console.Write("set Key \t= ");
			kunci = SetPlainNKunci();			
			//dataK = SetNilaiArray(kunci);	
			int n = 0;
			bool error;
			for (int i=0; i<plain.Length; i++) {
				string pecah = kunci.Substring(n,1);	
				error = true;
				for (int j=0; j<26; j++) {
					if (alfabet[j].Equals(pecah.ToString())) {
						dataK[i]=j;	
						n+=1;
						if (n==kunci.Length) {
							n=0;			
						}
						error = false;
						
					}
										
				}					
				if (error) {
					Console.WriteLine(pecah+" => else");
					Console.WriteLine("harus huruf bro !!!!");
					InputKunciNSet();
					break;
				}
				
			}
			Console.WriteLine();
			
		}
		private string SetPlainNKunci(){
			string rollback="";
			string temp = Convert.ToString(Console.ReadLine());
			rollback = temp.Replace(" ",string.Empty);
			rollback = rollback.ToUpper();
			return rollback;
		}
		public void SetDataH(){
			dataH = new int[plain.Length] ;
			
			for (int i=0; i<plain.Length; i++) {
				int temp = dataP[i]+dataK[i];
				int temp1 =Convert.ToInt32( temp%26);
				dataH[i] = temp1;
			}
			
			
		}
		public void ResumePlainText(){
			Console.Write("Plaintext  : ");
			for (int i=0; i<plain.Length; i++) {
				//Console.Write(dataP[i].ToString()+" ");
				Console.Write(alfabet[dataP[i]]+ " ");
			}
			Console.WriteLine();
			
		}
		public void ResumeKunci(){
			Console.Write("KeyWord    : ");
			for (int i=0; i<plain.Length; i++) {
				//Console.Write(dataK[i].ToString()+" ");
				Console.Write(alfabet[dataK[i]]+ " ");
			}
			Console.WriteLine();
			
		}
		public void finish(){
			Console.Write("Ciphertext : ");
			for (int i=0; i<plain.Length; i++) {
				Console.Write(alfabet[dataH[i]]+ " ");
			}
			Console.WriteLine();
		}
	}
}
