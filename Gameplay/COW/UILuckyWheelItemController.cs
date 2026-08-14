using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002961")]
public class UILuckyWheelItemController : UIBaseController
{
	[Token(Token = "0x2002962")]
	public enum ViewStage
	{
		[Token(Token = "0x400FF19")]
		NORMAL,
		[Token(Token = "0x400FF1A")]
		SELECTED,
		[Token(Token = "0x400FF1B")]
		GET_REWARD,
		[Token(Token = "0x400FF1C")]
		FINISHED
	}

	[Token(Token = "0x400FF13")]
	[FieldOffset(Offset = "0x28")]
	private UILuckyWheelItemView m_View;

	[Token(Token = "0x400FF14")]
	[FieldOffset(Offset = "0x2C")]
	private CSLuckyWheelDiscountDesc m_Desc;

	[Token(Token = "0x400FF15")]
	[FieldOffset(Offset = "0x30")]
	public int Index;

	[Token(Token = "0x400FF16")]
	[FieldOffset(Offset = "0x34")]
	private UIStandardItemMiniController m_UIStandardItemMiniController;

	[Token(Token = "0x400FF17")]
	[FieldOffset(Offset = "0x38")]
	private UIModelLuckyWheel m_Model;

	[Token(Token = "0x601093D")]
	[Address(RVA = "0x18C8CD0", Offset = "0x18C8CD0", VA = "0x18C8CD0")]
	public UILuckyWheelItemController()
	{
	}

	[Token(Token = "0x601093E")]
	[Address(RVA = "0x18C8D54", Offset = "0x18C8D54", VA = "0x18C8D54")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601093F")]
	[Address(RVA = "0x18C8DFC", Offset = "0x18C8DFC", VA = "0x18C8DFC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010940")]
	[Address(RVA = "0x18C8FD0", Offset = "0x18C8FD0", VA = "0x18C8FD0")]
	private void InitView()
	{
	}

	[Token(Token = "0x6010941")]
	[Address(RVA = "0x18C91A0", Offset = "0x18C91A0", VA = "0x18C91A0")]
	public uint GetUniqueID()
	{
		return default(uint);
	}

	[Token(Token = "0x6010942")]
	[Address(RVA = "0x18C920C", Offset = "0x18C920C", VA = "0x18C920C")]
	public void SetViewData(CSLuckyWheelDiscountDesc desc, int index)
	{
	}

	[Token(Token = "0x6010943")]
	[Address(RVA = "0x18C9D4C", Offset = "0x18C9D4C", VA = "0x18C9D4C")]
	public void ShowView(ViewStage stage)
	{
	}

	[Token(Token = "0x6010944")]
	[Address(RVA = "0x18C97E4", Offset = "0x18C97E4", VA = "0x18C97E4")]
	private void SetNormalStyle()
	{
	}

	[Token(Token = "0x6010945")]
	[Address(RVA = "0x18C9A50", Offset = "0x18C9A50", VA = "0x18C9A50")]
	private void SetGrayStyle()
	{
	}

	[Token(Token = "0x6010946")]
	[Address(RVA = "0x18CA01C", Offset = "0x18CA01C", VA = "0x18CA01C")]
	public bool IsUsed()
	{
		return default(bool);
	}

	[Token(Token = "0x6010947")]
	[Address(RVA = "0x18CA0C0", Offset = "0x18CA0C0", VA = "0x18CA0C0")]
	public void SetResetState()
	{
	}

	[Token(Token = "0x6010948")]
	[Address(RVA = "0x18CA1E8", Offset = "0x18CA1E8", VA = "0x18CA1E8")]
	private void OnItemBtnClick()
	{
	}

	[Token(Token = "0x6010949")]
	[Address(RVA = "0x18CA85C", Offset = "0x18CA85C", VA = "0x18CA85C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
