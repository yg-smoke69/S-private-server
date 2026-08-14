using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C06")]
public class UIWeaponSkinMenuFirstItemController : UIEasyListItemController
{
	[Token(Token = "0x4010CFF")]
	[FieldOffset(Offset = "0x38")]
	private UIWeaponSkinMenuFirstItemView m_View;

	[Token(Token = "0x4010D00")]
	[FieldOffset(Offset = "0x3C")]
	private object m_Data;

	[Token(Token = "0x601248E")]
	[Address(RVA = "0x2EDD980", Offset = "0x2EDD980", VA = "0x2EDD980")]
	public UIWeaponSkinMenuFirstItemController()
	{
	}

	[Token(Token = "0x601248F")]
	[Address(RVA = "0x2EDD988", Offset = "0x2EDD988", VA = "0x2EDD988", Slot = "30")]
	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012490")]
	[Address(RVA = "0x2EDD9E4", Offset = "0x2EDD9E4", VA = "0x2EDD9E4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012491")]
	[Address(RVA = "0x2EDDA8C", Offset = "0x2EDDA8C", VA = "0x2EDDA8C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012492")]
	[Address(RVA = "0x2EDDC7C", Offset = "0x2EDDC7C", VA = "0x2EDDC7C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6012493")]
	[Address(RVA = "0x2EDDDB0", Offset = "0x2EDDDB0", VA = "0x2EDDDB0")]
	private void OnRefreshRed(object[] data)
	{
	}

	[Token(Token = "0x6012494")]
	[Address(RVA = "0x2EDE080", Offset = "0x2EDE080", VA = "0x2EDE080", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6012495")]
	[Address(RVA = "0x2EDDFE8", Offset = "0x2EDDFE8", VA = "0x2EDDFE8")]
	private void RefreshRedTips(bool flag)
	{
	}

	[Token(Token = "0x6012496")]
	[Address(RVA = "0x2EDE428", Offset = "0x2EDE428", VA = "0x2EDE428", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x6012497")]
	[Address(RVA = "0x2EDE798", Offset = "0x2EDE798", VA = "0x2EDE798", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x6012498")]
	[Address(RVA = "0x2EDE86C", Offset = "0x2EDE86C", VA = "0x2EDE86C")]
	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012499")]
	[Address(RVA = "0x2EDE874", Offset = "0x2EDE874", VA = "0x2EDE874")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601249A")]
	[Address(RVA = "0x2EDE87C", Offset = "0x2EDE87C", VA = "0x2EDE87C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x601249B")]
	[Address(RVA = "0x2EDE884", Offset = "0x2EDE884", VA = "0x2EDE884")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x601249C")]
	[Address(RVA = "0x2EDE88C", Offset = "0x2EDE88C", VA = "0x2EDE88C")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
