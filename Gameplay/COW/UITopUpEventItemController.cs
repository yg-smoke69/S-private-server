using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002B71")]
public class UITopUpEventItemController : UIBaseController
{
	[Token(Token = "0x2002B72")]
	private sealed class _003CSetViewData_003Ec__AnonStorey0
	{
		[Token(Token = "0x4010A28")]
		[FieldOffset(Offset = "0x8")]
		internal AwardDesc awardDesc;

		[Token(Token = "0x4010A29")]
		[FieldOffset(Offset = "0xC")]
		internal UIStandardItemMiniController standardItem;

		[Token(Token = "0x6011EBD")]
		[Address(RVA = "0x2AF7390", Offset = "0x2AF7390", VA = "0x2AF7390")]
		public _003CSetViewData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6011EBE")]
		[Address(RVA = "0x2AF7D94", Offset = "0x2AF7D94", VA = "0x2AF7D94")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x4010A23")]
	[FieldOffset(Offset = "0x28")]
	private ClientActivityDesc m_Desc;

	[Token(Token = "0x4010A24")]
	[FieldOffset(Offset = "0x2C")]
	private UITopUpEventItemView m_View;

	[Token(Token = "0x4010A25")]
	[FieldOffset(Offset = "0x30")]
	private UIModelActivity m_Model;

	[Token(Token = "0x4010A26")]
	[FieldOffset(Offset = "0x34")]
	private List<UIStandardItemMiniController> m_ItemList;

	[Token(Token = "0x4010A27")]
	[FieldOffset(Offset = "0x38")]
	private UITopUpEventController.TopUpEventPageType m_TopUpEventPageType;

	[Token(Token = "0x6011EB4")]
	[Address(RVA = "0x2AF6FE8", Offset = "0x2AF6FE8", VA = "0x2AF6FE8")]
	public UITopUpEventItemController()
	{
	}

	[Token(Token = "0x6011EB5")]
	[Address(RVA = "0x2AF70A8", Offset = "0x2AF70A8", VA = "0x2AF70A8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011EB6")]
	[Address(RVA = "0x2AF7150", Offset = "0x2AF7150", VA = "0x2AF7150", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011EB7")]
	[Address(RVA = "0x2AF4CCC", Offset = "0x2AF4CCC", VA = "0x2AF4CCC")]
	public void SetViewData(ClientActivityDesc desc)
	{
	}

	[Token(Token = "0x6011EB8")]
	[Address(RVA = "0x2AF7398", Offset = "0x2AF7398", VA = "0x2AF7398")]
	private void OnTopUpClick()
	{
	}

	[Token(Token = "0x6011EB9")]
	[Address(RVA = "0x2AF422C", Offset = "0x2AF422C", VA = "0x2AF422C")]
	public void ResetSelected()
	{
	}

	[Token(Token = "0x6011EBA")]
	[Address(RVA = "0x2AF79D8", Offset = "0x2AF79D8", VA = "0x2AF79D8")]
	private void OnCliamClick()
	{
	}

	[Token(Token = "0x6011EBB")]
	[Address(RVA = "0x2AF4C6C", Offset = "0x2AF4C6C", VA = "0x2AF4C6C")]
	public void SetPageType(UITopUpEventController.TopUpEventPageType type)
	{
	}

	[Token(Token = "0x6011EBC")]
	[Address(RVA = "0x2AF7D8C", Offset = "0x2AF7D8C", VA = "0x2AF7D8C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
