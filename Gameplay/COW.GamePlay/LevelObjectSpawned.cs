using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x200066E")]
public abstract class LevelObjectSpawned : BaseLevelObject
{
	[Token(Token = "0x40047D8")]
	[FieldOffset(Offset = "0x74")]
	protected ResourceID GJADIFOFGPM;

	[Token(Token = "0x40047D9")]
	[FieldOffset(Offset = "0x78")]
	public IHAAMHPPLMG OwnerID;

	[Token(Token = "0x40047DA")]
	[FieldOffset(Offset = "0x90")]
	public byte TeamID;

	[Token(Token = "0x40047DB")]
	[FieldOffset(Offset = "0x91")]
	protected bool NOHNBMNLGKD;

	[Token(Token = "0x40047DC")]
	[FieldOffset(Offset = "0x94")]
	protected ResourceID CMMBEENEFAG;

	[Token(Token = "0x40047DD")]
	[FieldOffset(Offset = "0x98")]
	protected ResourceID CHDJGJCGKCE;

	[Token(Token = "0x60028E1")]
	[Address(RVA = "0x24B86CC", Offset = "0x24B86CC", VA = "0x24B86CC")]
	protected LevelObjectSpawned()
	{
	}

	[Token(Token = "0x60028E2")]
	[Address(RVA = "0x24CE914", Offset = "0x24CE914", VA = "0x24CE914")]
	public void OnCreate(IHAAMHPPLMG FIMNKGABILM, Vector3 ACCOJJMKKPM, Quaternion JGOGIAFGCFC, uint IOMFFBOHMBP, ResourceID JPFKGCMPLLM, [Optional] CSVBaseData AJKBOONEOAB)
	{
	}

	[Token(Token = "0x60028E3")]
	[Address(RVA = "0x24CEAEC", Offset = "0x24CEAEC", VA = "0x24CEAEC", Slot = "40")]
	protected virtual void LJAGPONMADJ()
	{
	}

	[Token(Token = "0x60028E4")]
	[Address(RVA = "0x24CEB58", Offset = "0x24CEB58", VA = "0x24CEB58")]
	protected void KDGGJAENLOL()
	{
	}

	[Token(Token = "0x60028E5")]
	[Address(RVA = "0x24CECAC", Offset = "0x24CECAC", VA = "0x24CECAC")]
	protected void DNFPBBJEPIK()
	{
	}

	[Token(Token = "0x60028E6")]
	[Address(RVA = "0x24B8D70", Offset = "0x24B8D70", VA = "0x24B8D70", Slot = "41")]
	protected virtual void DPLMGOJKKCM(CSVBaseData AJKBOONEOAB)
	{
	}

	[Token(Token = "0x60028E7")]
	[Address(RVA = "0x24B8DD0", Offset = "0x24B8DD0", VA = "0x24B8DD0", Slot = "42")]
	public virtual void OnDead(MEBEMEIFFBA OMNGGLFFMGM)
	{
	}

	[Token(Token = "0x60028E8")]
	[Address(RVA = "0x24CF3E8", Offset = "0x24CF3E8", VA = "0x24CF3E8", Slot = "43")]
	public virtual void DoDestroy()
	{
	}

	[Token(Token = "0x60028E9")]
	[Address(RVA = "0x24CF448", Offset = "0x24CF448", VA = "0x24CF448")]
	protected void BDKNAHCCFCF()
	{
	}

	[Token(Token = "0x60028EA")]
	[Address(RVA = "0x24CF63C", Offset = "0x24CF63C", VA = "0x24CF63C", Slot = "29")]
	protected override void UnRegisterEntity()
	{
	}

	[Token(Token = "0x60028EB")]
	[Address(RVA = "0x24CF6A8", Offset = "0x24CF6A8", VA = "0x24CF6A8", Slot = "44")]
	public bool IsVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x60028EC")]
	[Address(RVA = "0x24CF72C", Offset = "0x24CF72C", VA = "0x24CF72C", Slot = "45")]
	public virtual bool IsStreamerVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x60028ED")]
	[Address(RVA = "0x24CEE00", Offset = "0x24CEE00", VA = "0x24CEE00")]
	protected void IDGONNNLJCA(ResourceID IDNEFEOPGIF, [Optional] Transform GOLANILPAJP)
	{
	}

	[Token(Token = "0x60028EE")]
	[Address(RVA = "0x24CF324", Offset = "0x24CF324", VA = "0x24CF324")]
	protected void CLIPGBBEGNB(ResourceID DDDJHDHBFJB)
	{
	}

	[Token(Token = "0x60028EF")]
	[Address(RVA = "0x24BC704", Offset = "0x24BC704", VA = "0x24BC704")]
	protected void CLIPGBBEGNB(ResourceID DDDJHDHBFJB, ResourceID LMKMNAFNNJJ)
	{
	}

	[Token(Token = "0x60028F0")]
	[Address(RVA = "0x24CF784", Offset = "0x24CF784", VA = "0x24CF784")]
	public void _003C_003EiFixBaseProxy_UnRegisterEntity()
	{
	}
}
