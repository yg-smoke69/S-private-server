using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20028D1")]
public class UIHudWolfTaskController : UIBaseController
{
	[Token(Token = "0x20028D2")]
	private class WolfTaskButton
	{
		[Token(Token = "0x400FB1E")]
		[FieldOffset(Offset = "0x8")]
		public UIButton button;

		[Token(Token = "0x400FB1F")]
		[FieldOffset(Offset = "0xC")]
		public UISprite icon;

		[Token(Token = "0x400FB20")]
		[FieldOffset(Offset = "0x10")]
		public UITweener[] anim;

		[Token(Token = "0x400FB21")]
		[FieldOffset(Offset = "0x14")]
		public ALIODAIDAID info;

		[Token(Token = "0x6010181")]
		[Address(RVA = "0x2942EA4", Offset = "0x2942EA4", VA = "0x2942EA4")]
		public WolfTaskButton()
		{
		}

		[Token(Token = "0x6010182")]
		[Address(RVA = "0x2943BB8", Offset = "0x2943BB8", VA = "0x2943BB8")]
		public void OnButtonClick()
		{
		}

		[Token(Token = "0x6010183")]
		[Address(RVA = "0x29431E0", Offset = "0x29431E0", VA = "0x29431E0")]
		public void RefreshIcon()
		{
		}
	}

	[Token(Token = "0x400FB17")]
	[FieldOffset(Offset = "0x28")]
	private UIHudWolfTaskView m_View;

	[Token(Token = "0x400FB18")]
	[FieldOffset(Offset = "0x2C")]
	private List<WolfTaskButton> m_ButtonList;

	[Token(Token = "0x400FB19")]
	[FieldOffset(Offset = "0x30")]
	private List<ALIODAIDAID> m_TaskList;

	[Token(Token = "0x400FB1A")]
	[FieldOffset(Offset = "0x34")]
	private bool m_ButtonOpen;

	[Token(Token = "0x400FB1B")]
	[FieldOffset(Offset = "0x38")]
	private float m_cdTime;

	[Token(Token = "0x400FB1C")]
	[FieldOffset(Offset = "0x3C")]
	private float m_tarTime;

	[Token(Token = "0x400FB1D")]
	[FieldOffset(Offset = "0x40")]
	private bool m_Dead;

	[Token(Token = "0x601016E")]
	[Address(RVA = "0x2941AD4", Offset = "0x2941AD4", VA = "0x2941AD4")]
	public UIHudWolfTaskController()
	{
	}

	[Token(Token = "0x601016F")]
	[Address(RVA = "0x2941BC0", Offset = "0x2941BC0", VA = "0x2941BC0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010170")]
	[Address(RVA = "0x2941C68", Offset = "0x2941C68", VA = "0x2941C68", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010171")]
	[Address(RVA = "0x29423C8", Offset = "0x29423C8", VA = "0x29423C8", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6010172")]
	[Address(RVA = "0x29425CC", Offset = "0x29425CC", VA = "0x29425CC", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6010173")]
	[Address(RVA = "0x2942B60", Offset = "0x2942B60", VA = "0x2942B60")]
	private void ToggleButtons()
	{
	}

	[Token(Token = "0x6010174")]
	[Address(RVA = "0x2942064", Offset = "0x2942064", VA = "0x2942064")]
	private void InitTaskButton(UIButton button, UISprite icon)
	{
	}

	[Token(Token = "0x6010175")]
	[Address(RVA = "0x2942EAC", Offset = "0x2942EAC", VA = "0x2942EAC")]
	private void OnRoleChange(object[] data)
	{
	}

	[Token(Token = "0x6010176")]
	[Address(RVA = "0x2942690", Offset = "0x2942690", VA = "0x2942690")]
	private void OnRefreshWolfTask(object[] data)
	{
	}

	[Token(Token = "0x6010177")]
	[Address(RVA = "0x2943394", Offset = "0x2943394", VA = "0x2943394")]
	private int Cmp(ALIODAIDAID infoA, ALIODAIDAID infoB)
	{
		return default(int);
	}

	[Token(Token = "0x6010178")]
	[Address(RVA = "0x2943458", Offset = "0x2943458", VA = "0x2943458")]
	private void OnRefreshSkillCD(object[] data)
	{
	}

	[Token(Token = "0x6010179")]
	[Address(RVA = "0x29435B8", Offset = "0x29435B8", VA = "0x29435B8")]
	private void SetTaskCoolDown(bool value)
	{
	}

	[Token(Token = "0x601017A")]
	[Address(RVA = "0x2943728", Offset = "0x2943728", VA = "0x2943728")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x601017B")]
	[Address(RVA = "0x2943974", Offset = "0x2943974", VA = "0x2943974")]
	public Transform GetAllBtnTransform()
	{
		return null;
	}

	[Token(Token = "0x601017C")]
	[Address(RVA = "0x2943A00", Offset = "0x2943A00", VA = "0x2943A00")]
	public UIButton GetTutorialBtn()
	{
		return null;
	}

	[Token(Token = "0x601017D")]
	[Address(RVA = "0x2943AD0", Offset = "0x2943AD0", VA = "0x2943AD0")]
	public UIWidget GetTutorialWidget()
	{
		return null;
	}

	[Token(Token = "0x601017E")]
	[Address(RVA = "0x2943BA0", Offset = "0x2943BA0", VA = "0x2943BA0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601017F")]
	[Address(RVA = "0x2943BA8", Offset = "0x2943BA8", VA = "0x2943BA8")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	[Token(Token = "0x6010180")]
	[Address(RVA = "0x2943BB0", Offset = "0x2943BB0", VA = "0x2943BB0")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
