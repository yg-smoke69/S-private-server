using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003A9B")]
public class UIClanPrivilegeItemView : MonoBehaviour
{
	[Token(Token = "0x4018EC3")]
	[FieldOffset(Offset = "0xC")]
	private float _curBonus;

	[Token(Token = "0x4018EC4")]
	[FieldOffset(Offset = "0x10")]
	private float _nextBonus;

	[Token(Token = "0x4018EC5")]
	[FieldOffset(Offset = "0x14")]
	public int _privilegeType;

	[Token(Token = "0x4018EC6")]
	[FieldOffset(Offset = "0x18")]
	private UILabel _titleLabel;

	[Token(Token = "0x4018EC7")]
	[FieldOffset(Offset = "0x1C")]
	private UILabel _curBonusLabel;

	[Token(Token = "0x4018EC8")]
	[FieldOffset(Offset = "0x20")]
	private UILabel _nextBonusLabel;

	[Token(Token = "0x4018EC9")]
	[FieldOffset(Offset = "0x24")]
	private UISprite _icon;

	[Token(Token = "0x4018ECA")]
	private const string _bonusFormat = "+{0}";

	[Token(Token = "0x170016DB")]
	public string title
	{
		[Token(Token = "0x601738E")]
		[Address(RVA = "0x1469548", Offset = "0x1469548", VA = "0x1469548")]
		get
		{
			return null;
		}
		[Token(Token = "0x601738D")]
		[Address(RVA = "0x1469514", Offset = "0x1469514", VA = "0x1469514")]
		set
		{
		}
	}

	[Token(Token = "0x170016DC")]
	public float curBonus
	{
		[Token(Token = "0x6017390")]
		[Address(RVA = "0x1469704", Offset = "0x1469704", VA = "0x1469704")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x601738F")]
		[Address(RVA = "0x1469574", Offset = "0x1469574", VA = "0x1469574")]
		set
		{
		}
	}

	[Token(Token = "0x170016DD")]
	public float nextBonus
	{
		[Token(Token = "0x6017392")]
		[Address(RVA = "0x14698AC", Offset = "0x14698AC", VA = "0x14698AC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6017391")]
		[Address(RVA = "0x146970C", Offset = "0x146970C", VA = "0x146970C")]
		set
		{
		}
	}

	[Token(Token = "0x170016DE")]
	public bool hasNextLevel
	{
		[Token(Token = "0x6017393")]
		[Address(RVA = "0x14698B4", Offset = "0x14698B4", VA = "0x14698B4")]
		set
		{
		}
	}

	[Token(Token = "0x170016DF")]
	public string iconName
	{
		[Token(Token = "0x6017394")]
		[Address(RVA = "0x1469908", Offset = "0x1469908", VA = "0x1469908")]
		set
		{
		}
	}

	[Token(Token = "0x601738C")]
	[Address(RVA = "0x146950C", Offset = "0x146950C", VA = "0x146950C")]
	public UIClanPrivilegeItemView()
	{
	}

	[Token(Token = "0x6017395")]
	[Address(RVA = "0x14699C4", Offset = "0x14699C4", VA = "0x14699C4")]
	public void Show()
	{
	}

	[Token(Token = "0x6017396")]
	[Address(RVA = "0x14699FC", Offset = "0x14699FC", VA = "0x14699FC")]
	public void Hide()
	{
	}
}
