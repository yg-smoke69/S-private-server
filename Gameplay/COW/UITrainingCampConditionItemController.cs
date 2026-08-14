using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B75")]
public class UITrainingCampConditionItemController : UIBaseController
{
	[Token(Token = "0x4010A32")]
	[FieldOffset(Offset = "0x28")]
	private UITrainingCampConditionItemView m_View;

	[Token(Token = "0x4010A33")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_IsOK;

	[Token(Token = "0x4010A34")]
	[FieldOffset(Offset = "0x30")]
	private int m_Index;

	[Token(Token = "0x170012EB")]
	public bool IsOK
	{
		[Token(Token = "0x6011EE6")]
		[Address(RVA = "0x2AFC4F0", Offset = "0x2AFC4F0", VA = "0x2AFC4F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170012EC")]
	public int Index
	{
		[Token(Token = "0x6011EE7")]
		[Address(RVA = "0x2AFC548", Offset = "0x2AFC548", VA = "0x2AFC548")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6011EE1")]
	[Address(RVA = "0x2AFC080", Offset = "0x2AFC080", VA = "0x2AFC080")]
	public UITrainingCampConditionItemController()
	{
	}

	[Token(Token = "0x6011EE2")]
	[Address(RVA = "0x2AFC104", Offset = "0x2AFC104", VA = "0x2AFC104")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011EE3")]
	[Address(RVA = "0x2AFC1A8", Offset = "0x2AFC1A8", VA = "0x2AFC1A8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011EE4")]
	[Address(RVA = "0x2AFC264", Offset = "0x2AFC264", VA = "0x2AFC264")]
	public void SetCondition(int index, string condition, object[] param)
	{
	}

	[Token(Token = "0x6011EE5")]
	[Address(RVA = "0x2AFC3C4", Offset = "0x2AFC3C4", VA = "0x2AFC3C4")]
	public void SetStatus(bool isOK)
	{
	}

	[Token(Token = "0x6011EE8")]
	[Address(RVA = "0x2AFC5A0", Offset = "0x2AFC5A0", VA = "0x2AFC5A0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
