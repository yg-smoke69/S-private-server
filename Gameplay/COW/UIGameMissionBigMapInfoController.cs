using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002694")]
internal class UIGameMissionBigMapInfoController : UIBaseController
{
	[Token(Token = "0x400EE09")]
	[FieldOffset(Offset = "0x28")]
	private UIGameMissionBigMapInfoView m_View;

	[Token(Token = "0x400EE0A")]
	[FieldOffset(Offset = "0x2C")]
	private DEBJENPEHIJ m_Mission;

	[Token(Token = "0x400EE0B")]
	[FieldOffset(Offset = "0x30")]
	private float m_TimeCount;

	[Token(Token = "0x400EE0C")]
	[FieldOffset(Offset = "0x34")]
	private bool m_HasTimeWaring;

	[Token(Token = "0x400EE0D")]
	[FieldOffset(Offset = "0x38")]
	private UIGrid m_ParentGrid;

	[Token(Token = "0x600E808")]
	[Address(RVA = "0x245F0E4", Offset = "0x245F0E4", VA = "0x245F0E4")]
	public UIGameMissionBigMapInfoController()
	{
	}

	[Token(Token = "0x600E809")]
	[Address(RVA = "0x245F168", Offset = "0x245F168", VA = "0x245F168")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E80A")]
	[Address(RVA = "0x245F210", Offset = "0x245F210", VA = "0x245F210", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E80B")]
	[Address(RVA = "0x245F428", Offset = "0x245F428", VA = "0x245F428")]
	public void SetViewData(DEBJENPEHIJ mission, string description, UIGrid parentGrid)
	{
	}

	[Token(Token = "0x600E80C")]
	[Address(RVA = "0x245F778", Offset = "0x245F778", VA = "0x245F778")]
	private void Update()
	{
	}

	[Token(Token = "0x600E80D")]
	[Address(RVA = "0x245FBB4", Offset = "0x245FBB4", VA = "0x245FBB4")]
	private void OnMissionClose(object[] data)
	{
	}

	[Token(Token = "0x600E80E")]
	[Address(RVA = "0x245FD44", Offset = "0x245FD44", VA = "0x245FD44")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
