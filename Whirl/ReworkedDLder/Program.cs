using System;
using System.Threading;
using System.Windows.Forms;
using Whirl;

namespace ReworkedDLder
{
	// Token: 0x02000007 RID: 7
	internal static class Program
	{
		// Token: 0x06000032 RID: 50 RVA: 0x00002950 File Offset: 0x00000B50
		[STAThread]
		public static async void Music()
		{
			Stuff.Note[] tune = new Stuff.Note[]
			{
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.THIRD2),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.THIRD2),
				new Stuff.Note(Stuff.Tone.Gs4, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.THIRD2),
				new Stuff.Note(Stuff.Tone.F5, Stuff.Duration.THIRD2),
				new Stuff.Note(Stuff.Tone.Gs5, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.Fs5, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.F5, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.THIRD2),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.THIRD2),
				new Stuff.Note(Stuff.Tone.Gs4, Stuff.Duration.HALF)
			};
			Stuff.Note[] tune2 = new Stuff.Note[]
			{
				new Stuff.Note(Stuff.Tone.Gs5, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.Fs5, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.F5, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.SIXTEENTH)
			};
			Stuff.Note[] tune3 = new Stuff.Note[]
			{
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.REST, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.SIXTEENTH)
			};
			Stuff.Note[] tune4 = new Stuff.Note[]
			{
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.C5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.C5, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.Gs4, Stuff.Duration.HALF),
				new Stuff.Note(Stuff.Tone.REST, Stuff.Duration.HALF),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.C5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.REST, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Gs4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Gs5, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.Gs5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.HALF),
				new Stuff.Note(Stuff.Tone.REST, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.C5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.REST, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.C5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.C5, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.Gs4, Stuff.Duration.HALF),
				new Stuff.Note(Stuff.Tone.REST, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.C5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Gs4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.REST, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.F5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.HALF),
				new Stuff.Note(Stuff.Tone.REST, Stuff.Duration.HALF)
			};
			Stuff.Note[] tune5 = new Stuff.Note[]
			{
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.HALF),
				new Stuff.Note(Stuff.Tone.REST, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.F5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.F5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Gs4, Stuff.Duration.HALF),
				new Stuff.Note(Stuff.Tone.REST, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.C5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.REST, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.F5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.REST, Stuff.Duration.EIGHTH)
			};
			Stuff.Note[] tune6 = new Stuff.Note[]
			{
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.C5, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.F5, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.F5, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.THIRD2),
				new Stuff.Note(Stuff.Tone.Gs4, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.C5, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.Gs4, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.C5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.C5, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.C5, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Gs4, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.F4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.HALF),
				new Stuff.Note(Stuff.Tone.REST, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.C5, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.F5, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.F5, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.THIRD2),
				new Stuff.Note(Stuff.Tone.Gs4, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.C5, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.Gs4, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.Gs5, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.C5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.THIRD2),
				new Stuff.Note(Stuff.Tone.C5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Gs4, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.C5, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.Gs4, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.C5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Gs4, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.F4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.HALF)
			};
			Stuff.Note[] tune7 = new Stuff.Note[]
			{
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.REST, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.C5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.C5, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.Gs4, Stuff.Duration.THIRD2),
				new Stuff.Note(Stuff.Tone.REST, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.C5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Gs4, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.REST, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Gs5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Gs5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.F5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.REST, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.C5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.C5, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.Gs4, Stuff.Duration.THIRD2),
				new Stuff.Note(Stuff.Tone.REST, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.C5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Gs4, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.REST, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.F5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.F5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.REST, Stuff.Duration.EIGHTH)
			};
			Stuff.Note[] tune8 = new Stuff.Note[]
			{
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.HALF),
				new Stuff.Note(Stuff.Tone.REST, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.F5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.F5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Gs4, Stuff.Duration.HALF),
				new Stuff.Note(Stuff.Tone.REST, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.C5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.REST, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.F5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.Ds5, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.REST, Stuff.Duration.EIGHTH)
			};
			Stuff.Note[] tune9 = new Stuff.Note[]
			{
				new Stuff.Note(Stuff.Tone.Gs5, Stuff.Duration.WHOLE)
			};
			Stuff.Note[] tune10 = new Stuff.Note[]
			{
				new Stuff.Note(Stuff.Tone.Cs6, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.Cs6, Stuff.Duration.QUARTER),
				new Stuff.Note(Stuff.Tone.C6, Stuff.Duration.QUARTER)
			};
			Stuff.Note[] tune11 = new Stuff.Note[]
			{
				new Stuff.Note(Stuff.Tone.REST, Stuff.Duration.THIRD2),
				new Stuff.Note(Stuff.Tone.Gs5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.C5, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.F5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.C5, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.Cs5, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.As4, Stuff.Duration.SIXTEENTH),
				new Stuff.Note(Stuff.Tone.F5, Stuff.Duration.EIGHTH),
				new Stuff.Note(Stuff.Tone.REST, Stuff.Duration.QUARTER)
			};
			Stuff.Play(tune);
			Thread.Sleep(530);
			Stuff.Play(tune2);
			Stuff.Play(tune);
			Stuff.Play(tune3);
			Thread.Sleep(1060);
			Stuff.Play(tune4);
			Stuff.Play(tune5);
			Stuff.Play(tune6);
			Stuff.Play(tune7);
			Stuff.Play(tune8);
			Stuff.Play(tune6);
			Stuff.Play(tune9);
			Stuff.Play(tune10);
			Stuff.Play(tune11);
			Stuff.Play(tune10);
			Stuff.Play(tune11);
			Stuff.Play(tune7);
			Stuff.Play(tune8);
			Stuff.Play(tune6);
			Stuff.Play(tune6);
			Stuff.Play(tune6);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002984 File Offset: 0x00000B84
		private static void Main(string[] args)
		{
			bool flag = true;
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			string a = "";
			try
			{
				a = args[1];
			}
			catch
			{
			}
			if (flag || a == "rickroll")
			{
				Program.Music();
				return;
			}
			Application.Run(new Form1(args));
		}
	}
}
