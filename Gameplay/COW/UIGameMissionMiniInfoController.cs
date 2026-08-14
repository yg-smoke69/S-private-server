using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002695")]
internal class UIGameMissionMiniInfoController : UIBaseController
{
	[Token(Token = "0x400EE0E")]
	[FieldOffset(Offset = "0x28")]
	private UIGameMissionMiniInfoView m_View;

	[Token(Token = "0x400EE0F")]
	[FieldOffset(Offset = "0x2C")]
	private DEBJENPEHIJ m_Mission;

	[Token(Token = "0x400EE10")]
	[FieldOffset(Offset = "0x30")]
	private float m_TimeCount;

	[Token(Token = "0x400EE11")]
	[FieldOffset(Offset = "0x34")]
	private bool m_HasTimeWaring;

	[Token(Token = "0x400EE12")]
	[FieldOffset(Offset = "0x38")]
	private UITable m_ParentTable;

	[Token(Token = "0x600E80F")]
	[Address(RVA = "0x2460144", Offset = "0x2460144", VA = "0x2460144")]
	public UIGameMissionMiniInfoController()
	{
	}

	[Token(Token = "0x600E810")]
	[Address(RVA = "0x24601C8", Offset = "0x24601C8", VA = "0x24601C8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E811")]
	[Address(RVA = "0x2460270", Offset = "0x2460270", VA = "0x2460270", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E812")]
	[Address(RVA = "0x2460488", Offset = "0x2460488", VA = "0x2460488")]
	public void SetViewData(DEBJENPEHIJ mission, UITable parentTable)
	{
	}

	[Token(Token = "0x600E813")]
	[Address(RVA = "0x2460608", Offset = "0x2460608", VA = "0x2460608")]
	private void Update()
	{
	}

	[Token(Token = "0x600E814")]
	[Address(RVA = "0x2460A44", Offset = "0x2460A44", VA = "0x2460A44")]
	private void OnMissionClose(object[] data)
	{
	}

	[Token(Token = "0x600E815")]
	[Address(RVA = "0x2460BD4", Offset = "0x2460BD4", VA = "0x2460BD4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
