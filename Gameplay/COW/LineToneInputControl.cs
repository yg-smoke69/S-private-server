using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002396")]
public class LineToneInputControl : UIDragDropItem
{
	[Token(Token = "0x400DDA4")]
	[FieldOffset(Offset = "0x6C")]
	private LineTone controlTone;

	[Token(Token = "0x400DDA5")]
	[FieldOffset(Offset = "0x70")]
	private MusicMiniGamePhaseOneGameData m_data;

	[Token(Token = "0x400DDA6")]
	[FieldOffset(Offset = "0x74")]
	private SphereCollider startPointCollider;

	[Token(Token = "0x400DDA7")]
	[FieldOffset(Offset = "0x78")]
	private SphereCollider endPointCollider;

	[Token(Token = "0x400DDA8")]
	[FieldOffset(Offset = "0x7C")]
	private Vector3 startPos;

	[Token(Token = "0x400DDA9")]
	[FieldOffset(Offset = "0x88")]
	private Vector3 endPos;

	[Token(Token = "0x400DDAA")]
	[FieldOffset(Offset = "0x94")]
	private float startPrefectTime;

	[Token(Token = "0x400DDAB")]
	[FieldOffset(Offset = "0x98")]
	private float endPrefectTime;

	[Token(Token = "0x400DDAC")]
	[FieldOffset(Offset = "0x9C")]
	private float prefectGap;

	[Token(Token = "0x400DDAD")]
	[FieldOffset(Offset = "0xA0")]
	private float goodGap;

	[Token(Token = "0x400DDAE")]
	[FieldOffset(Offset = "0xA4")]
	private float completeGap;

	[Token(Token = "0x400DDAF")]
	[FieldOffset(Offset = "0xA8")]
	private bool isDragStart;

	[Token(Token = "0x400DDB0")]
	[FieldOffset(Offset = "0xA9")]
	private bool isInit;

	[Token(Token = "0x400DDB1")]
	[FieldOffset(Offset = "0xAC")]
	private Vector3 currentPrefectPos;

	[Token(Token = "0x400DDB2")]
	[FieldOffset(Offset = "0xB8")]
	private Transform prefectPosPoint;

	[Token(Token = "0x400DDB3")]
	[FieldOffset(Offset = "0xBC")]
	private Transform movePoint;

	[Token(Token = "0x600C7E7")]
	[Address(RVA = "0xEC5EBC", Offset = "0xEC5EBC", VA = "0xEC5EBC")]
	public LineToneInputControl()
	{
	}

	[Token(Token = "0x600C7E8")]
	[Address(RVA = "0xEC44C8", Offset = "0xEC44C8", VA = "0xEC44C8")]
	public void SetData(LineTone controlTone, SphereCollider startPointCollider, SphereCollider endPointCollider, SingerMiniMusicGamePhaseOneConfigData conf, MusicMiniGamePhaseOneGameData mdata, Transform movePoint, Transform prefectPosPoint)
	{
	}

	[Token(Token = "0x600C7E9")]
	[Address(RVA = "0xEC4968", Offset = "0xEC4968", VA = "0xEC4968")]
	public void ResetToneInput()
	{
	}

	[Token(Token = "0x600C7EA")]
	[Address(RVA = "0xEC5E40", Offset = "0xEC5E40", VA = "0xEC5E40")]
	public void StopToneInput()
	{
	}

	[Token(Token = "0x600C7EB")]
	[Address(RVA = "0xEC5F40", Offset = "0xEC5F40", VA = "0xEC5F40", Slot = "9")]
	protected override void Update()
	{
	}

	[Token(Token = "0x600C7EC")]
	[Address(RVA = "0xEC62E8", Offset = "0xEC62E8", VA = "0xEC62E8", Slot = "10")]
	protected override void OnDragStart()
	{
	}

	[Token(Token = "0x600C7ED")]
	[Address(RVA = "0xEC64CC", Offset = "0xEC64CC", VA = "0xEC64CC")]
	private void ShowDragStartEffect()
	{
	}

	[Token(Token = "0x600C7EE")]
	[Address(RVA = "0xEC6540", Offset = "0xEC6540", VA = "0xEC6540", Slot = "13")]
	protected override void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x600C7EF")]
	[Address(RVA = "0xEC662C", Offset = "0xEC662C", VA = "0xEC662C", Slot = "14")]
	protected override void OnDragEnd()
	{
	}

	[Token(Token = "0x600C7F0")]
	[Address(RVA = "0xEC6910", Offset = "0xEC6910", VA = "0xEC6910")]
	private void ShowDragEndEffect()
	{
	}

	[Token(Token = "0x600C7F1")]
	[Address(RVA = "0xEC6984", Offset = "0xEC6984", VA = "0xEC6984")]
	public void _003C_003EiFixBaseProxy_Update()
	{
	}

	[Token(Token = "0x600C7F2")]
	[Address(RVA = "0xEC698C", Offset = "0xEC698C", VA = "0xEC698C")]
	public void _003C_003EiFixBaseProxy_OnDragStart()
	{
	}

	[Token(Token = "0x600C7F3")]
	[Address(RVA = "0xEC6994", Offset = "0xEC6994", VA = "0xEC6994")]
	public void _003C_003EiFixBaseProxy_OnDrag(Vector2 P0)
	{
	}

	[Token(Token = "0x600C7F4")]
	[Address(RVA = "0xEC699C", Offset = "0xEC699C", VA = "0xEC699C")]
	public void _003C_003EiFixBaseProxy_OnDragEnd()
	{
	}
}
