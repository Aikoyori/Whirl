using System;
using System.Threading;

namespace Whirl
{
	// Token: 0x02000002 RID: 2
	internal class Stuff
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static int ToDuration(int tempo)
		{
			return 60000 / tempo;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000205C File Offset: 0x0000025C
		public static void Play(Stuff.Note[] tune)
		{
			foreach (Stuff.Note note in tune)
			{
				if (note.NoteTone == Stuff.Tone.REST)
				{
					Thread.Sleep((int)note.NoteDuration);
				}
				else
				{
					Console.Beep((int)note.NoteTone, (int)note.NoteDuration);
				}
			}
		}

		// Token: 0x04000001 RID: 1
		public Stuff.Note[] Mary = new Stuff.Note[0];

		// Token: 0x04000002 RID: 2
		private const int TEMPO = 113;

		// Token: 0x02000008 RID: 8
		public enum Tone
		{
			// Token: 0x04000013 RID: 19
			B3 = 250,
			// Token: 0x04000014 RID: 20
			C4 = 265,
			// Token: 0x04000015 RID: 21
			Cs4 = 280,
			// Token: 0x04000016 RID: 22
			D4 = 297,
			// Token: 0x04000017 RID: 23
			Ds4 = 315,
			// Token: 0x04000018 RID: 24
			E4 = 334,
			// Token: 0x04000019 RID: 25
			F4 = 353,
			// Token: 0x0400001A RID: 26
			Fs4 = 375,
			// Token: 0x0400001B RID: 27
			G4 = 397,
			// Token: 0x0400001C RID: 28
			Gs4 = 420,
			// Token: 0x0400001D RID: 29
			A4 = 446,
			// Token: 0x0400001E RID: 30
			As4 = 472,
			// Token: 0x0400001F RID: 31
			B4 = 500,
			// Token: 0x04000020 RID: 32
			C5 = 530,
			// Token: 0x04000021 RID: 33
			Cs5 = 561,
			// Token: 0x04000022 RID: 34
			D5 = 595,
			// Token: 0x04000023 RID: 35
			Ds5 = 630,
			// Token: 0x04000024 RID: 36
			E5 = 668,
			// Token: 0x04000025 RID: 37
			F5 = 707,
			// Token: 0x04000026 RID: 38
			Fs5 = 750,
			// Token: 0x04000027 RID: 39
			G5 = 794,
			// Token: 0x04000028 RID: 40
			Gs5 = 841,
			// Token: 0x04000029 RID: 41
			A5 = 892,
			// Token: 0x0400002A RID: 42
			As5 = 945,
			// Token: 0x0400002B RID: 43
			B5 = 1001,
			// Token: 0x0400002C RID: 44
			C6 = 1060,
			// Token: 0x0400002D RID: 45
			Cs6 = 1123,
			// Token: 0x0400002E RID: 46
			D6 = 1190,
			// Token: 0x0400002F RID: 47
			Ds6 = 1261,
			// Token: 0x04000030 RID: 48
			E6 = 1336,
			// Token: 0x04000031 RID: 49
			F6 = 1415,
			// Token: 0x04000032 RID: 50
			Fs6 = 1500,
			// Token: 0x04000033 RID: 51
			G6 = 1589,
			// Token: 0x04000034 RID: 52
			Gs6 = 1683,
			// Token: 0x04000035 RID: 53
			A6 = 1784,
			// Token: 0x04000036 RID: 54
			As6 = 1890,
			// Token: 0x04000037 RID: 55
			B6 = 2002,
			// Token: 0x04000038 RID: 56
			REST = 0
		}

		// Token: 0x02000009 RID: 9
		public enum Duration
		{
			// Token: 0x0400003A RID: 58
			WHOLE = 2120,
			// Token: 0x0400003B RID: 59
			HALF = 1060,
			// Token: 0x0400003C RID: 60
			QUARTER = 530,
			// Token: 0x0400003D RID: 61
			THIRD = 1590,
			// Token: 0x0400003E RID: 62
			EIGHTH = 265,
			// Token: 0x0400003F RID: 63
			THIRD2 = 795,
			// Token: 0x04000040 RID: 64
			SIXTEENTH = 132
		}

		// Token: 0x0200000A RID: 10
		public struct Note
		{
			// Token: 0x06000034 RID: 52 RVA: 0x000029E0 File Offset: 0x00000BE0
			public Note(Stuff.Tone frequency, Stuff.Duration time)
			{
				this.toneVal = frequency;
				this.durVal = time;
			}

			// Token: 0x17000005 RID: 5
			// (get) Token: 0x06000035 RID: 53 RVA: 0x000029F0 File Offset: 0x00000BF0
			public Stuff.Tone NoteTone
			{
				get
				{
					return this.toneVal;
				}
			}

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x06000036 RID: 54 RVA: 0x000029F8 File Offset: 0x00000BF8
			public Stuff.Duration NoteDuration
			{
				get
				{
					return this.durVal;
				}
			}

			// Token: 0x04000041 RID: 65
			private Stuff.Tone toneVal;

			// Token: 0x04000042 RID: 66
			private Stuff.Duration durVal;
		}
	}
}
