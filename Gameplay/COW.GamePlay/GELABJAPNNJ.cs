using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2001E33")]
public class GELABJAPNNJ : _Attribute
{
	[Token(Token = "0x2001E34")]
	private class BAMANNMJJFB : Player
	{
		[Token(Token = "0x400BECA")]
		[FieldOffset(Offset = "0x0")]
		private static uint DPFIHGFOMJC;

		[Token(Token = "0x400BECB")]
		[FieldOffset(Offset = "0x998")]
		private int DKKIEFDEOIK;

		[Token(Token = "0x400BECC")]
		[FieldOffset(Offset = "0x99C")]
		private Action<bool> GFIOOJACFEF;

		[Token(Token = "0x60090E8")]
		[Address(RVA = "0x1085920", Offset = "0x1085920", VA = "0x1085920")]
		public BAMANNMJJFB()
		{
		}

		[Token(Token = "0x60090E9")]
		[Address(RVA = "0x1083E7C", Offset = "0x1083E7C", VA = "0x1083E7C")]
		public void InitShootingGameTarget(IHAAMHPPLMG IDNEFEOPGIF, Transform LHGLOHKNEPC, Action<bool> LGLHPPDIKBC)
		{
		}

		[Token(Token = "0x60090EA")]
		[Address(RVA = "0x10859A4", Offset = "0x10859A4", VA = "0x10859A4", Slot = "124")]
		public override int TakeDamage(int KOCMLPLOILD, IHAAMHPPLMG HLJDHPGGODB, [Optional] ELMGJKHIIAA JIIJIFKKCCB, int BOEIBGAABDL = -1, [Optional] Vector3 NJMFBKNHMBP, [Optional] Vector3 DOBOBMFMKBJ, [Optional] List<float> NBKBEBFNDBE, [Optional] MKFEKBKJCKE OPINPCANMDE, uint GGIDKOBOJBB = 0u)
		{
			return default(int);
		}

		[Token(Token = "0x60090EB")]
		[Address(RVA = "0x1084D18", Offset = "0x1084D18", VA = "0x1084D18")]
		public void Hide()
		{
		}

		[Token(Token = "0x60090EC")]
		[Address(RVA = "0x1083568", Offset = "0x1083568", VA = "0x1083568")]
		public void EquipVest(uint OABCDJKEHFH)
		{
		}

		[Token(Token = "0x60090ED")]
		[Address(RVA = "0x1084770", Offset = "0x1084770", VA = "0x1084770")]
		public void Show(int ABLGPCAPELM)
		{
		}

		[Token(Token = "0x60090EE")]
		[Address(RVA = "0x1086614", Offset = "0x1086614", VA = "0x1086614", Slot = "51")]
		public override bool NeedAssit()
		{
			return default(bool);
		}

		[Token(Token = "0x60090EF")]
		[Address(RVA = "0x108666C", Offset = "0x108666C", VA = "0x108666C", Slot = "52")]
		public override bool CanAssitByWeapon(Player DEKAHNJALPI, GPBDEDFKJNA LPGPKFMGCBG)
		{
			return default(bool);
		}

		[Token(Token = "0x60090F1")]
		[Address(RVA = "0x10868F4", Offset = "0x10868F4", VA = "0x10868F4")]
		public int _003C_003EiFixBaseProxy_TakeDamage(int P0, IHAAMHPPLMG P1, ELMGJKHIIAA P2, int P3, Vector3 P4, Vector3 P5, List<float> P6, MKFEKBKJCKE P7, uint P8)
		{
			return default(int);
		}

		[Token(Token = "0x60090F2")]
		[Address(RVA = "0x108697C", Offset = "0x108697C", VA = "0x108697C")]
		public bool _003C_003EiFixBaseProxy_NeedAssit()
		{
			return default(bool);
		}

		[Token(Token = "0x60090F3")]
		[Address(RVA = "0x1086984", Offset = "0x1086984", VA = "0x1086984")]
		public new bool _003C_003EiFixBaseProxy_CanAssitByWeapon(Player P0, GPBDEDFKJNA P1)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001E35")]
	private enum MMJMADPFKIF
	{
		[Token(Token = "0x400BECE")]
		None,
		[Token(Token = "0x400BECF")]
		WaitShoot,
		[Token(Token = "0x400BED0")]
		WaitNext
	}

	[Token(Token = "0x400BEC1")]
	[FieldOffset(Offset = "0x8")]
	private TrainingShootingGameData JKMMBKBBOJL;

	[Token(Token = "0x400BEC2")]
	[FieldOffset(Offset = "0xC")]
	private BAMANNMJJFB LNIKKLFNJDF;

	[Token(Token = "0x400BEC3")]
	[FieldOffset(Offset = "0x10")]
	private TrainingShootGameRandomArea HFJNDCPKELD;

	[Token(Token = "0x400BEC4")]
	[FieldOffset(Offset = "0x14")]
	private uint COMBDCMPDEP;

	[Token(Token = "0x400BEC5")]
	[FieldOffset(Offset = "0x18")]
	private uint MKMDEEAHPDJ;

	[Token(Token = "0x400BEC6")]
	[FieldOffset(Offset = "0x1C")]
	private MMJMADPFKIF HLBJCABDBEA;

	[Token(Token = "0x400BEC7")]
	[FieldOffset(Offset = "0x20")]
	private float MHOOMMHMNGG;

	[Token(Token = "0x400BEC8")]
	[FieldOffset(Offset = "0x24")]
	private uint IFBHMKMGLMA;

	[Token(Token = "0x400BEC9")]
	[FieldOffset(Offset = "0x28")]
	private TrainingShootingGameData.Level FANOGNGFPFC;

	[Token(Token = "0x17000F2D")]
	public bool GFIFINMJACE
	{
		[Token(Token = "0x60090D7")]
		[Address(RVA = "0x1083760", Offset = "0x1083760", VA = "0x1083760", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60090D3")]
	[Address(RVA = "0x10831EC", Offset = "0x10831EC", VA = "0x10831EC")]
	public GELABJAPNNJ()
	{
	}

	[Token(Token = "0x60090D4")]
	[Address(RVA = "0x10831F4", Offset = "0x10831F4", VA = "0x10831F4")]
	private void HKDDPOLLPLK(MMJMADPFKIF IMGNBGJDAHG)
	{
	}

	[Token(Token = "0x60090D5")]
	[Address(RVA = "0x1083264", Offset = "0x1083264", VA = "0x1083264", Slot = "4")]
	public void FMLNBLAKPOP()
	{
	}

	[Token(Token = "0x60090D6")]
	[Address(RVA = "0x10833FC", Offset = "0x10833FC", VA = "0x10833FC")]
	private void HGMNONMNLGJ(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x60090D8")]
	[Address(RVA = "0x10837CC", Offset = "0x10837CC", VA = "0x10837CC", Slot = "5")]
	public void HDAIOCDAFPN()
	{
	}

	[Token(Token = "0x60090D9")]
	[Address(RVA = "0x1084268", Offset = "0x1084268", VA = "0x1084268")]
	private void AAMMIDLKLNM()
	{
	}

	[Token(Token = "0x60090DA")]
	[Address(RVA = "0x1084804", Offset = "0x1084804", VA = "0x1084804")]
	public void ACKIBGLDMEL(bool LLFPIOMKPGD)
	{
	}

	[Token(Token = "0x60090DB")]
	[Address(RVA = "0x1084AA8", Offset = "0x1084AA8", VA = "0x1084AA8")]
	private void BFEFEIELGNO()
	{
	}

	[Token(Token = "0x60090DC")]
	[Address(RVA = "0x1084BF4", Offset = "0x1084BF4", VA = "0x1084BF4", Slot = "7")]
	public void HCOPINOKOKO()
	{
	}

	[Token(Token = "0x60090DD")]
	[Address(RVA = "0x1084DA0", Offset = "0x1084DA0", VA = "0x1084DA0", Slot = "6")]
	public void MODIHEKHMGF()
	{
	}

	[Token(Token = "0x60090DE")]
	[Address(RVA = "0x1084E00", Offset = "0x1084E00", VA = "0x1084E00", Slot = "8")]
	public void OOOOOBAECAG()
	{
	}

	[Token(Token = "0x60090DF")]
	[Address(RVA = "0x1084E6C", Offset = "0x1084E6C", VA = "0x1084E6C", Slot = "9")]
	public void FPIFKMPMIGH(bool FDJAGBNHIED = false)
	{
	}

	[Token(Token = "0x60090E0")]
	[Address(RVA = "0x108510C", Offset = "0x108510C", VA = "0x108510C", Slot = "10")]
	public void EGEIKFFPAAM()
	{
	}

	[Token(Token = "0x60090E1")]
	[Address(RVA = "0x1083D24", Offset = "0x1083D24", VA = "0x1083D24")]
	private void NMFIBMOGFEM(bool IMGNBGJDAHG)
	{
	}

	[Token(Token = "0x60090E2")]
	[Address(RVA = "0x108523C", Offset = "0x108523C", VA = "0x108523C", Slot = "11")]
	public float NEGLPKLOGPJ()
	{
		return default(float);
	}

	[Token(Token = "0x60090E3")]
	[Address(RVA = "0x1085294", Offset = "0x1085294", VA = "0x1085294", Slot = "12")]
	public List<string> HDJJAHMMNMH()
	{
		return null;
	}

	[Token(Token = "0x60090E4")]
	[Address(RVA = "0x1085484", Offset = "0x1085484", VA = "0x1085484", Slot = "13")]
	public List<string> JPCGGDMHFGJ(float FMHAAJMOHBC)
	{
		return null;
	}

	[Token(Token = "0x60090E5")]
	[Address(RVA = "0x1084A44", Offset = "0x1084A44", VA = "0x1084A44", Slot = "14")]
	public uint GMNHEEFDPIL()
	{
		return default(uint);
	}

	[Token(Token = "0x60090E6")]
	[Address(RVA = "0x10857F0", Offset = "0x10857F0", VA = "0x10857F0", Slot = "15")]
	public MIIKFKLHDKI BPFFLDCMCGJ()
	{
		return default(MIIKFKLHDKI);
	}

	[Token(Token = "0x60090E7")]
	[Address(RVA = "0x1085848", Offset = "0x1085848", VA = "0x1085848", Slot = "16")]
	public ResourceID CCEHLOCLDDP()
	{
		return default(ResourceID);
	}
}
