using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002979")]
public class UIManualGrownItemGroupController : UIBaseController
{
	[Token(Token = "0x200297A")]
	public enum State
	{
		[Token(Token = "0x400FF89")]
		NONE,
		[Token(Token = "0x400FF8A")]
		AWARDED,
		[Token(Token = "0x400FF8B")]
		CAN_AWARD,
		[Token(Token = "0x400FF8C")]
		CAN_NOT_AWARD
	}

	[Token(Token = "0x400FF82")]
	[FieldOffset(Offset = "0x28")]
	private UIManualGrownItemGroupView m_View;

	[Token(Token = "0x400FF83")]
	[FieldOffset(Offset = "0x2C")]
	private List<UIManualGrownItemController> m_ItmCtrlList;

	[Token(Token = "0x400FF84")]
	[FieldOffset(Offset = "0x30")]
	private List<GameObject> m_PosList;

	[Token(Token = "0x400FF85")]
	[FieldOffset(Offset = "0x34")]
	private LevelRewardData m_Data;

	[Token(Token = "0x400FF86")]
	[FieldOffset(Offset = "0x38")]
	private GameObject m_Porgress;

	[Token(Token = "0x400FF87")]
	[FieldOffset(Offset = "0x3C")]
	private int m_Indx;

	[Token(Token = "0x1700125F")]
	public GameObject ProgressLine
	{
		[Token(Token = "0x6010A3E")]
		[Address(RVA = "0x2C25CC8", Offset = "0x2C25CC8", VA = "0x2C25CC8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6010A3D")]
		[Address(RVA = "0x2C24678", Offset = "0x2C24678", VA = "0x2C24678")]
		set
		{
		}
	}

	[Token(Token = "0x17001260")]
	public int Idx
	{
		[Token(Token = "0x6010A3F")]
		[Address(RVA = "0x2C245C0", Offset = "0x2C245C0", VA = "0x2C245C0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6010A40")]
		[Address(RVA = "0x2C2479C", Offset = "0x2C2479C", VA = "0x2C2479C")]
		set
		{
		}
	}

	[Token(Token = "0x6010A3C")]
	[Address(RVA = "0x2C25BB8", Offset = "0x2C25BB8", VA = "0x2C25BB8")]
	public UIManualGrownItemGroupController()
	{
	}

	[Token(Token = "0x6010A41")]
	[Address(RVA = "0x2C25D20", Offset = "0x2C25D20", VA = "0x2C25D20")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010A42")]
	[Address(RVA = "0x2C25DC4", Offset = "0x2C25DC4", VA = "0x2C25DC4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010A43")]
	[Address(RVA = "0x2C2634C", Offset = "0x2C2634C", VA = "0x2C2634C", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6010A44")]
	[Address(RVA = "0x2C263B0", Offset = "0x2C263B0", VA = "0x2C263B0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010A45")]
	[Address(RVA = "0x2C261AC", Offset = "0x2C261AC", VA = "0x2C261AC")]
	private void InitPosList()
	{
	}

	[Token(Token = "0x6010A46")]
	[Address(RVA = "0x2C26414", Offset = "0x2C26414", VA = "0x2C26414")]
	private void EnablePosList(bool enable)
	{
	}

	[Token(Token = "0x6010A47")]
	[Address(RVA = "0x2C265E8", Offset = "0x2C265E8", VA = "0x2C265E8")]
	private void EnabelItmCtrlList(bool enable)
	{
	}

	[Token(Token = "0x6010A48")]
	[Address(RVA = "0x2C25E90", Offset = "0x2C25E90", VA = "0x2C25E90")]
	private void InitItmCtrlList()
	{
	}

	[Token(Token = "0x6010A49")]
	[Address(RVA = "0x2C24618", Offset = "0x2C24618", VA = "0x2C24618")]
	public void SetData(LevelRewardData data)
	{
	}

	[Token(Token = "0x6010A4A")]
	[Address(RVA = "0x2C246D8", Offset = "0x2C246D8", VA = "0x2C246D8")]
	public void RefreshView()
	{
	}

	[Token(Token = "0x6010A4B")]
	[Address(RVA = "0x2C267BC", Offset = "0x2C267BC", VA = "0x2C267BC")]
	private State CalState()
	{
		return default(State);
	}

	[Token(Token = "0x6010A4C")]
	[Address(RVA = "0x2C26940", Offset = "0x2C26940", VA = "0x2C26940")]
	private void DoShowView(State state)
	{
	}

	[Token(Token = "0x6010A4D")]
	[Address(RVA = "0x2C26C60", Offset = "0x2C26C60", VA = "0x2C26C60")]
	private void SetLevel()
	{
	}

	[Token(Token = "0x6010A4E")]
	[Address(RVA = "0x2C26FF8", Offset = "0x2C26FF8", VA = "0x2C26FF8")]
	private void ShowLv1View()
	{
	}

	[Token(Token = "0x6010A4F")]
	[Address(RVA = "0x2C270A8", Offset = "0x2C270A8", VA = "0x2C270A8")]
	private void ShowRewardView(State state)
	{
	}

	[Token(Token = "0x6010A50")]
	[Address(RVA = "0x2C273E8", Offset = "0x2C273E8", VA = "0x2C273E8")]
	private void ShowProgress(State state)
	{
	}

	[Token(Token = "0x6010A51")]
	[Address(RVA = "0x2C27500", Offset = "0x2C27500", VA = "0x2C27500")]
	private void SetProgressEnable(bool enable)
	{
	}

	[Token(Token = "0x6010A52")]
	[Address(RVA = "0x2C276C4", Offset = "0x2C276C4", VA = "0x2C276C4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010A53")]
	[Address(RVA = "0x2C276CC", Offset = "0x2C276CC", VA = "0x2C276CC")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x6010A54")]
	[Address(RVA = "0x2C276D4", Offset = "0x2C276D4", VA = "0x2C276D4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
