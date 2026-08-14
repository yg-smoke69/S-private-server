using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using message;

namespace COW.GamePlay;

[Token(Token = "0x2000727")]
internal class UGCAttackableMiniSentry : AttackableEntity
{
	[Token(Token = "0x4004C44")]
	[FieldOffset(Offset = "0x48")]
	public UGCLevelMiniSentry mMiniSentry;

	[Token(Token = "0x6002D1B")]
	[Address(RVA = "0x1D86948", Offset = "0x1D86948", VA = "0x1D86948")]
	public UGCAttackableMiniSentry()
	{
	}

	[Token(Token = "0x6002D1C")]
	[Address(RVA = "0x1D86950", Offset = "0x1D86950", VA = "0x1D86950", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002D1D")]
	[Address(RVA = "0x1D869A8", Offset = "0x1D869A8", VA = "0x1D869A8")]
	protected CHDLJFJCPFN CCPAJNBFGOE()
	{
		return null;
	}

	[Token(Token = "0x6002D1E")]
	[Address(RVA = "0x1D86B00", Offset = "0x1D86B00", VA = "0x1D86B00")]
	public void TakeDamageByVehicle(int JLKLMFHFHFF, IHAAMHPPLMG KAEHJEGFKBL, DBNMCJLEFJI JPLHIDNDING, int BOEIBGAABDL)
	{
	}

	[Token(Token = "0x6002D1F")]
	[Address(RVA = "0x1D86CB4", Offset = "0x1D86CB4", VA = "0x1D86CB4", Slot = "54")]
	public override void TakeDamage(ELMGJKHIIAA JIIJIFKKCCB, [Optional] MKFEKBKJCKE OPINPCANMDE, [Optional] List<float> NBKBEBFNDBE, uint GGIDKOBOJBB = 0u)
	{
	}

	[Token(Token = "0x6002D20")]
	[Address(RVA = "0x1D86EB0", Offset = "0x1D86EB0", VA = "0x1D86EB0")]
	public void _003C_003EiFixBaseProxy_TakeDamage(ELMGJKHIIAA P0, MKFEKBKJCKE P1, List<float> P2, uint P3)
	{
	}
}
