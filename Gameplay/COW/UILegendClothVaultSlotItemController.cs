using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002907")]
public class UILegendClothVaultSlotItemController : UIPopupWindowController
{
	[Token(Token = "0x400FCA5")]
	[FieldOffset(Offset = "0x48")]
	private UILegendClothVaultSlotItemView m_View;

	[Token(Token = "0x400FCA6")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelAvatarBase.EWardrobeType m_WardrobeType;

	[Token(Token = "0x400FCA7")]
	[FieldOffset(Offset = "0x50")]
	private LegendClothVaultPageType m_PageType;

	[Token(Token = "0x400FCA8")]
	[FieldOffset(Offset = "0x54")]
	private Color m_WearingColor;

	[Token(Token = "0x400FCA9")]
	[FieldOffset(Offset = "0x64")]
	private Color m_NotWearingColor;

	[Token(Token = "0x400FCAA")]
	private const uint InvalidClothId = 0u;

	[Token(Token = "0x400FCAB")]
	[FieldOffset(Offset = "0x74")]
	private uint _003CClothId_003Ek__BackingField;

	[Token(Token = "0x400FCAC")]
	[FieldOffset(Offset = "0x78")]
	private int _003CLevel_003Ek__BackingField;

	[Token(Token = "0x400FCAD")]
	[FieldOffset(Offset = "0x7C")]
	private bool _003CIsWearing_003Ek__BackingField;

	[Token(Token = "0x400FCAE")]
	[FieldOffset(Offset = "0x7D")]
	private bool m_IsGenderValid;

	[Token(Token = "0x17001211")]
	public uint ClothId
	{
		[Token(Token = "0x601040E")]
		[Address(RVA = "0x25417AC", Offset = "0x25417AC", VA = "0x25417AC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x601040F")]
		[Address(RVA = "0x25417B4", Offset = "0x25417B4", VA = "0x25417B4")]
		private set
		{
		}
	}

	[Token(Token = "0x17001212")]
	public int Level
	{
		[Token(Token = "0x6010410")]
		[Address(RVA = "0x25417BC", Offset = "0x25417BC", VA = "0x25417BC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6010411")]
		[Address(RVA = "0x25417C4", Offset = "0x25417C4", VA = "0x25417C4")]
		private set
		{
		}
	}

	[Token(Token = "0x17001213")]
	public bool IsWearing
	{
		[Token(Token = "0x6010412")]
		[Address(RVA = "0x25417CC", Offset = "0x25417CC", VA = "0x25417CC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6010413")]
		[Address(RVA = "0x25417D4", Offset = "0x25417D4", VA = "0x25417D4")]
		private set
		{
		}
	}

	[Token(Token = "0x601040D")]
	[Address(RVA = "0x2541714", Offset = "0x2541714", VA = "0x2541714")]
	public UILegendClothVaultSlotItemController()
	{
	}

	[Token(Token = "0x6010414")]
	[Address(RVA = "0x25417DC", Offset = "0x25417DC", VA = "0x25417DC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010415")]
	[Address(RVA = "0x2541880", Offset = "0x2541880", VA = "0x2541880", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010416")]
	[Address(RVA = "0x2541A50", Offset = "0x2541A50", VA = "0x2541A50", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6010417")]
	[Address(RVA = "0x2541AB4", Offset = "0x2541AB4", VA = "0x2541AB4")]
	public void SetData(UIModelAvatarBase.EWardrobeType wardrobeType, uint clothId, int level = -1)
	{
	}

	[Token(Token = "0x6010418")]
	[Address(RVA = "0x2542180", Offset = "0x2542180", VA = "0x2542180")]
	public void SetPageType(LegendClothVaultPageType pageType)
	{
	}

	[Token(Token = "0x6010419")]
	[Address(RVA = "0x25422A0", Offset = "0x25422A0", VA = "0x25422A0")]
	private void OnClickBtnChoose()
	{
	}

	[Token(Token = "0x601041A")]
	[Address(RVA = "0x2542860", Offset = "0x2542860", VA = "0x2542860")]
	private void OnClickBtnCancel()
	{
	}

	[Token(Token = "0x601041B")]
	[Address(RVA = "0x2541B44", Offset = "0x2541B44", VA = "0x2541B44")]
	public void RefreshView()
	{
	}

	[Token(Token = "0x601041C")]
	[Address(RVA = "0x2542A90", Offset = "0x2542A90", VA = "0x2542A90")]
	public void SetIsGenderValid(bool isGenderValid)
	{
	}

	[Token(Token = "0x601041D")]
	[Address(RVA = "0x2542800", Offset = "0x2542800", VA = "0x2542800")]
	public void SetIsWearing(bool isWearing)
	{
	}

	[Token(Token = "0x601041E")]
	[Address(RVA = "0x2542AF0", Offset = "0x2542AF0", VA = "0x2542AF0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601041F")]
	[Address(RVA = "0x2542AF8", Offset = "0x2542AF8", VA = "0x2542AF8")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
