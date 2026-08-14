using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x200060B")]
public class LevelDetailItemGenerator : BaseLevelObject
{
	[Token(Token = "0x200060C")]
	public enum JNCMCDACLGC
	{
		[Token(Token = "0x4004598")]
		Add,
		[Token(Token = "0x4004599")]
		Destroy
	}

	[Token(Token = "0x400458A")]
	[FieldOffset(Offset = "0x74")]
	public uint m_ItemID;

	[Token(Token = "0x400458B")]
	[FieldOffset(Offset = "0x78")]
	public float m_RefreshInterval;

	[Token(Token = "0x400458C")]
	[FieldOffset(Offset = "0x7C")]
	public uint m_ItemCount;

	[Token(Token = "0x400458D")]
	[FieldOffset(Offset = "0x80")]
	public bool m_AlwaysGenerate;

	[Token(Token = "0x400458E")]
	[FieldOffset(Offset = "0x81")]
	public bool m_WaitStart;

	[Token(Token = "0x400458F")]
	[FieldOffset(Offset = "0x84")]
	public GameObject m_TipObject;

	[Token(Token = "0x4004590")]
	[FieldOffset(Offset = "0x88")]
	public MeshRenderer m_TimeRender;

	[Token(Token = "0x4004591")]
	[FieldOffset(Offset = "0x8C")]
	private Material LNJCFHGOFNL;

	[Token(Token = "0x4004592")]
	[FieldOffset(Offset = "0x90")]
	private uint BPJMMILEGBD;

	[Token(Token = "0x4004593")]
	[FieldOffset(Offset = "0x94")]
	private GameObject EPKEHAOJGCK;

	[Token(Token = "0x4004594")]
	private const float OGKDPMONLBM = 0.45f;

	[Token(Token = "0x4004595")]
	private const float HFPEBNIAJDK = 1f;

	[Token(Token = "0x4004596")]
	private const float NKGHIDPOMCL = 0.55f;

	[Token(Token = "0x6002549")]
	[Address(RVA = "0x2714980", Offset = "0x2714980", VA = "0x2714980")]
	public LevelDetailItemGenerator()
	{
	}

	[Token(Token = "0x600254A")]
	[Address(RVA = "0x2714990", Offset = "0x2714990", VA = "0x2714990", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x600254B")]
	[Address(RVA = "0x2714A34", Offset = "0x2714A34", VA = "0x2714A34", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x600254C")]
	[Address(RVA = "0x2714CB4", Offset = "0x2714CB4", VA = "0x2714CB4")]
	public void OnNewPropGenerated()
	{
	}

	[Token(Token = "0x600254D")]
	[Address(RVA = "0x2714E78", Offset = "0x2714E78", VA = "0x2714E78", Slot = "18")]
	public override void OnUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x600254E")]
	[Address(RVA = "0x27151A4", Offset = "0x27151A4", VA = "0x27151A4")]
	private void FMDAFKOLOGP()
	{
	}

	[Token(Token = "0x600254F")]
	[Address(RVA = "0x27152A4", Offset = "0x27152A4", VA = "0x27152A4", Slot = "16")]
	protected override void OnOnDestroy()
	{
	}

	[Token(Token = "0x6002550")]
	[Address(RVA = "0x2715454", Offset = "0x2715454", VA = "0x2715454")]
	public void ShowInMap(string PICNONKEHDF)
	{
	}

	[Token(Token = "0x6002551")]
	[Address(RVA = "0x27156D4", Offset = "0x27156D4", VA = "0x27156D4")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	[Token(Token = "0x6002552")]
	[Address(RVA = "0x27156DC", Offset = "0x27156DC", VA = "0x27156DC")]
	public void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}

	[Token(Token = "0x6002553")]
	[Address(RVA = "0x27156E4", Offset = "0x27156E4", VA = "0x27156E4")]
	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}
}
