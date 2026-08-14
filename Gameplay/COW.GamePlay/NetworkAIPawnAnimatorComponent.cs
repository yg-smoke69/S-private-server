using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x20003D8")]
internal class NetworkAIPawnAnimatorComponent : NetworkAIPawnAnimBaseComponent
{
	[Token(Token = "0x400393A")]
	[FieldOffset(Offset = "0x1C")]
	private Animator KNONGIAOOFA;

	[Token(Token = "0x1700019D")]
	public override Animator GBGNONFPAOF
	{
		[Token(Token = "0x6001134")]
		[Address(RVA = "0x17EBC8C", Offset = "0x17EBC8C", VA = "0x17EBC8C", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001133")]
	[Address(RVA = "0x17EBC74", Offset = "0x17EBC74", VA = "0x17EBC74")]
	public NetworkAIPawnAnimatorComponent()
	{
	}

	[Token(Token = "0x6001135")]
	[Address(RVA = "0x17EBCE4", Offset = "0x17EBCE4", VA = "0x17EBCE4", Slot = "4")]
	public override void Init(NetworkAIPawn FIMNKGABILM, [Optional] Animation CFGGELHHJLD, [Optional] Animator HLIOOJLOAGA)
	{
	}

	[Token(Token = "0x6001136")]
	[Address(RVA = "0x17EBE0C", Offset = "0x17EBE0C", VA = "0x17EBE0C", Slot = "10")]
	public override void Dead(bool KCHNLMEEHOP, bool FDICOIFLBAD)
	{
	}

	[Token(Token = "0x6001137")]
	[Address(RVA = "0x17EBF4C", Offset = "0x17EBF4C", VA = "0x17EBF4C", Slot = "11")]
	public override void SetSpeed(float OJGNBJELDEM)
	{
	}

	[Token(Token = "0x6001138")]
	[Address(RVA = "0x17EC064", Offset = "0x17EC064", VA = "0x17EC064", Slot = "12")]
	public override bool PlaySkillAnim(OPKPPFDNCMC GEPIPPKAIBK, GDEHAFJBPGE LGIMFPCBALH, float GGMFDABGEKN, float NCGNOHEHDML, bool ICLFBLKGENK)
	{
		return default(bool);
	}

	[Token(Token = "0x6001139")]
	[Address(RVA = "0x17EC110", Offset = "0x17EC110", VA = "0x17EC110")]
	public Animator _003C_003EiFixBaseProxy_get_Animator()
	{
		return null;
	}
}
