using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200238B")]
public class UIQuickMessageCustomItemController : UIEasyListItemController
{
	[Token(Token = "0x400DD5B")]
	[FieldOffset(Offset = "0x38")]
	private UIQuickMessageCustomItemView m_View;

	[Token(Token = "0x600C78A")]
	[Address(RVA = "0x1AC2708", Offset = "0x1AC2708", VA = "0x1AC2708")]
	public UIQuickMessageCustomItemController()
	{
	}

	[Token(Token = "0x600C78B")]
	[Address(RVA = "0x1AC2710", Offset = "0x1AC2710", VA = "0x1AC2710", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C78C")]
	[Address(RVA = "0x1AC27CC", Offset = "0x1AC27CC", VA = "0x1AC27CC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C78D")]
	[Address(RVA = "0x1AC2874", Offset = "0x1AC2874", VA = "0x1AC2874", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600C78E")]
	[Address(RVA = "0x1AC28E4", Offset = "0x1AC28E4", VA = "0x1AC28E4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
