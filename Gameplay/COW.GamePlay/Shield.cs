using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using message;

namespace COW.GamePlay;

[Token(Token = "0x2000719")]
internal class Shield : AttackableEntity
{
	[Token(Token = "0x4004C1B")]
	[FieldOffset(Offset = "0x48")]
	private LevelShield OGFJIEMCJCL;

	[Token(Token = "0x4004C1C")]
	[FieldOffset(Offset = "0x4C")]
	private uint MMAJKBBCOIO;

	[Token(Token = "0x6002CF3")]
	[Address(RVA = "0x1D72580", Offset = "0x1D72580", VA = "0x1D72580")]
	public Shield()
	{
	}

	[Token(Token = "0x6002CF4")]
	[Address(RVA = "0x1D72588", Offset = "0x1D72588", VA = "0x1D72588")]
	public uint GetOwnerVehicleID()
	{
		return default(uint);
	}

	[Token(Token = "0x6002CF5")]
	[Address(RVA = "0x1D725E0", Offset = "0x1D725E0", VA = "0x1D725E0", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002CF6")]
	[Address(RVA = "0x1D72638", Offset = "0x1D72638", VA = "0x1D72638")]
	internal void DPLMGOJKKCM(LevelShield GGJEBHEMKED)
	{
	}

	[Token(Token = "0x6002CF7")]
	[Address(RVA = "0x1D726BC", Offset = "0x1D726BC", VA = "0x1D726BC")]
	public bool IsActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6002CF8")]
	[Address(RVA = "0x1D727CC", Offset = "0x1D727CC", VA = "0x1D727CC")]
	protected CHDLJFJCPFN PNGAJBCPDNJ()
	{
		return null;
	}

	[Token(Token = "0x6002CF9")]
	[Address(RVA = "0x1D72918", Offset = "0x1D72918", VA = "0x1D72918", Slot = "61")]
	public virtual void TakeDamageByVehicle(int JLKLMFHFHFF, IHAAMHPPLMG KAEHJEGFKBL, DBNMCJLEFJI JPLHIDNDING, int BOEIBGAABDL)
	{
	}

	[Token(Token = "0x6002CFA")]
	[Address(RVA = "0x1D72ACC", Offset = "0x1D72ACC", VA = "0x1D72ACC", Slot = "54")]
	public override void TakeDamage(ELMGJKHIIAA JIIJIFKKCCB, [Optional] MKFEKBKJCKE OPINPCANMDE, [Optional] List<float> NBKBEBFNDBE, uint GGIDKOBOJBB = 0u)
	{
	}

	[Token(Token = "0x6002CFB")]
	[Address(RVA = "0x1D72CC8", Offset = "0x1D72CC8", VA = "0x1D72CC8")]
	public void _003C_003EiFixBaseProxy_TakeDamage(ELMGJKHIIAA P0, MKFEKBKJCKE P1, List<float> P2, uint P3)
	{
	}
}
