using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x200060A")]
public class LevelDestructiblePartObject : BaseLevelObject
{
	[Token(Token = "0x4004581")]
	[FieldOffset(Offset = "0x74")]
	public uint PartDataID;

	[Token(Token = "0x4004582")]
	[FieldOffset(Offset = "0x78")]
	public GameObject ServerCollider;

	[Token(Token = "0x4004583")]
	[FieldOffset(Offset = "0x7C")]
	private GameObject BKFECPOCPMK;

	[Token(Token = "0x4004584")]
	[FieldOffset(Offset = "0x80")]
	private ResourceID EINDAGOKGDL;

	[Token(Token = "0x4004585")]
	[FieldOffset(Offset = "0x84")]
	private bool ODPILEKNJCL;

	[Token(Token = "0x4004586")]
	[FieldOffset(Offset = "0x88")]
	private DestructibleObjectConfigData DHAHMDCHKFN;

	[Token(Token = "0x4004587")]
	[FieldOffset(Offset = "0x8C")]
	private uint HGHENLNEJIK;

	[Token(Token = "0x4004588")]
	[FieldOffset(Offset = "0x90")]
	private uint ALLGDFDIPBC;

	[Token(Token = "0x4004589")]
	[FieldOffset(Offset = "0x94")]
	protected BitArrayBoolean FAGCPHGJGPI;

	[Token(Token = "0x6002535")]
	[Address(RVA = "0x2711FE8", Offset = "0x2711FE8", VA = "0x2711FE8")]
	public LevelDestructiblePartObject()
	{
	}

	[Token(Token = "0x6002536")]
	[Address(RVA = "0x27120B4", Offset = "0x27120B4", VA = "0x27120B4", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002537")]
	[Address(RVA = "0x2712158", Offset = "0x2712158", VA = "0x2712158", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6002538")]
	[Address(RVA = "0x2711B48", Offset = "0x2711B48", VA = "0x2711B48")]
	public void SetInitialHP(uint ABLGPCAPELM)
	{
	}

	[Token(Token = "0x6002539")]
	[Address(RVA = "0x27125D4", Offset = "0x27125D4", VA = "0x27125D4", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x600253A")]
	[Address(RVA = "0x2712800", Offset = "0x2712800", VA = "0x2712800")]
	public int GetCurHP()
	{
		return default(int);
	}

	[Token(Token = "0x600253B")]
	[Address(RVA = "0x2712924", Offset = "0x2712924", VA = "0x2712924")]
	public void SetHP(int LBMGGMBKAEH)
	{
	}

	[Token(Token = "0x600253C")]
	[Address(RVA = "0x2712B80", Offset = "0x2712B80", VA = "0x2712B80")]
	public uint GetStatus()
	{
		return default(uint);
	}

	[Token(Token = "0x600253D")]
	[Address(RVA = "0x2712CA4", Offset = "0x2712CA4", VA = "0x2712CA4")]
	public void onStatusChange(uint JGLJDJFHPBO, uint DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x600253E")]
	[Address(RVA = "0x2713FB8", Offset = "0x2713FB8", VA = "0x2713FB8", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x600253F")]
	[Address(RVA = "0x2712354", Offset = "0x2712354", VA = "0x2712354")]
	public void SetNormalState()
	{
	}

	[Token(Token = "0x6002540")]
	[Address(RVA = "0x2712D60", Offset = "0x2712D60", VA = "0x2712D60")]
	public void OnBroken()
	{
	}

	[Token(Token = "0x6002541")]
	[Address(RVA = "0x2713240", Offset = "0x2713240", VA = "0x2713240")]
	public void OnNeedDestroy()
	{
	}

	[Token(Token = "0x6002542")]
	[Address(RVA = "0x2714010", Offset = "0x2714010", VA = "0x2714010")]
	public void RecycleModel()
	{
	}

	[Token(Token = "0x6002543")]
	[Address(RVA = "0x2710A74", Offset = "0x2710A74", VA = "0x2710A74")]
	public void LoadModel(bool FKHMOFHBOCC)
	{
	}

	[Token(Token = "0x6002544")]
	[Address(RVA = "0x2714218", Offset = "0x2714218", VA = "0x2714218")]
	private List<Vector2> LAGCANCOGCE()
	{
		return null;
	}

	[Token(Token = "0x6002545")]
	[Address(RVA = "0x2714700", Offset = "0x2714700", VA = "0x2714700")]
	private void OIPKMPEDHCI()
	{
	}

	[Token(Token = "0x6002546")]
	[Address(RVA = "0x2714968", Offset = "0x2714968", VA = "0x2714968")]
	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x6002547")]
	[Address(RVA = "0x2714970", Offset = "0x2714970", VA = "0x2714970")]
	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6002548")]
	[Address(RVA = "0x2714978", Offset = "0x2714978", VA = "0x2714978")]
	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return default(int);
	}
}
