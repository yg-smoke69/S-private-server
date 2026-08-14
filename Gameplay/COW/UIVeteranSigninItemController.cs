using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002BF2")]
public class UIVeteranSigninItemController : UIBaseController
{
	[Token(Token = "0x4010C79")]
	[FieldOffset(Offset = "0x28")]
	private UIVeteranSigninItemView m_View;

	[Token(Token = "0x4010C7A")]
	[FieldOffset(Offset = "0x2C")]
	private UIWidget m_ItemWidget;

	[Token(Token = "0x4010C7B")]
	private const string QUALITY_FORMAT = "UI_quality_{0}";

	[Token(Token = "0x4010C7C")]
	[FieldOffset(Offset = "0x30")]
	private int m_IndexInList;

	[Token(Token = "0x4010C7D")]
	[FieldOffset(Offset = "0x34")]
	private bool m_IsVeteran;

	[Token(Token = "0x17001313")]
	public bool IsVeteran
	{
		[Token(Token = "0x601237D")]
		[Address(RVA = "0x2CC3104", Offset = "0x2CC3104", VA = "0x2CC3104")]
		set
		{
		}
	}

	[Token(Token = "0x17001314")]
	public Vector2 ItemSize
	{
		[Token(Token = "0x601237E")]
		[Address(RVA = "0x2CC3720", Offset = "0x2CC3720", VA = "0x2CC3720")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector2);
		}
		[Token(Token = "0x601237F")]
		[Address(RVA = "0x2CC3920", Offset = "0x2CC3920", VA = "0x2CC3920")]
		set
		{
		}
	}

	[Token(Token = "0x601237B")]
	[Address(RVA = "0x2CC35F8", Offset = "0x2CC35F8", VA = "0x2CC35F8")]
	public UIVeteranSigninItemController()
	{
	}

	[Token(Token = "0x601237C")]
	[Address(RVA = "0x2CC367C", Offset = "0x2CC367C", VA = "0x2CC367C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012380")]
	[Address(RVA = "0x2CC3AF0", Offset = "0x2CC3AF0", VA = "0x2CC3AF0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012381")]
	[Address(RVA = "0x2CC3D28", Offset = "0x2CC3D28", VA = "0x2CC3D28")]
	private void OnItemClick()
	{
	}

	[Token(Token = "0x6012382")]
	[Address(RVA = "0x2CC2EAC", Offset = "0x2CC2EAC", VA = "0x2CC2EAC")]
	public void SetRewardData(VeteranRewardItem item, int listIndex, bool isLastOne = false)
	{
	}

	[Token(Token = "0x6012383")]
	[Address(RVA = "0x2CC3E5C", Offset = "0x2CC3E5C", VA = "0x2CC3E5C")]
	private void SetDayCountLabel(uint dayID)
	{
	}

	[Token(Token = "0x6012384")]
	[Address(RVA = "0x2CC4374", Offset = "0x2CC4374", VA = "0x2CC4374")]
	private void AdjustView(AwardItemInfo awardInfo, bool isLastOne = false)
	{
	}

	[Token(Token = "0x6012385")]
	[Address(RVA = "0x2CC4C08", Offset = "0x2CC4C08", VA = "0x2CC4C08")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
