using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002BF9")]
internal class UIVibrateSettingController : UISettingContentBase
{
	[Token(Token = "0x2002BFA")]
	private sealed class _003CSetGroupChange_003Ec__AnonStorey0
	{
		[Token(Token = "0x4010CA9")]
		[FieldOffset(Offset = "0x8")]
		internal GameObject[] subGroups;

		[Token(Token = "0x4010CAA")]
		[FieldOffset(Offset = "0xC")]
		internal int hideSubBtnFlag;

		[Token(Token = "0x4010CAB")]
		[FieldOffset(Offset = "0x10")]
		internal UIGrid subContainer;

		[Token(Token = "0x4010CAC")]
		[FieldOffset(Offset = "0x14")]
		internal UIVibrateSettingController _0024this;

		[Token(Token = "0x60123F1")]
		[Address(RVA = "0x10189C4", Offset = "0x10189C4", VA = "0x10189C4")]
		public _003CSetGroupChange_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60123F2")]
		[Address(RVA = "0x1018AD0", Offset = "0x1018AD0", VA = "0x1018AD0")]
		internal void _003C_003Em__0(int selectContent)
		{
		}
	}

	[Token(Token = "0x4010CA7")]
	[FieldOffset(Offset = "0x2C")]
	private UIVibrateSettingView m_View;

	[Token(Token = "0x4010CA8")]
	[FieldOffset(Offset = "0x30")]
	private List<GameObject> m_openedGroups;

	[Token(Token = "0x60123E6")]
	[Address(RVA = "0x1016EB4", Offset = "0x1016EB4", VA = "0x1016EB4")]
	public UIVibrateSettingController()
	{
	}

	[Token(Token = "0x60123E7")]
	[Address(RVA = "0x1016EBC", Offset = "0x1016EBC", VA = "0x1016EBC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60123E8")]
	[Address(RVA = "0x1016F64", Offset = "0x1016F64", VA = "0x1016F64", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60123E9")]
	[Address(RVA = "0x1018318", Offset = "0x1018318", VA = "0x1018318")]
	private void ResetScrollViewWidth()
	{
	}

	[Token(Token = "0x60123EA")]
	[Address(RVA = "0x1018534", Offset = "0x1018534", VA = "0x1018534")]
	private void OnVisibleVoice_CarSoundHintClicked()
	{
	}

	[Token(Token = "0x60123EB")]
	[Address(RVA = "0x101877C", Offset = "0x101877C", VA = "0x101877C")]
	private void OnVisibleVoice_GunFireHintClicked()
	{
	}

	[Token(Token = "0x60123EC")]
	[Address(RVA = "0x1017DF8", Offset = "0x1017DF8", VA = "0x1017DF8")]
	private GameObject[] InitGourpBtnsByConfig(GameObject[] subGroups, bool[] enableds, GameObject root)
	{
		return null;
	}

	[Token(Token = "0x60123ED")]
	[Address(RVA = "0x1018104", Offset = "0x1018104", VA = "0x1018104")]
	private void SetGroupChange(UISettingToggleBtnGroup mainBtnGroup, GameObject[] subGroups, UIGrid subContainer, int hideSubBtnFlag)
	{
	}

	[Token(Token = "0x60123EE")]
	[Address(RVA = "0x10189CC", Offset = "0x10189CC", VA = "0x10189CC", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60123EF")]
	[Address(RVA = "0x1018AC0", Offset = "0x1018AC0", VA = "0x1018AC0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60123F0")]
	[Address(RVA = "0x1018AC8", Offset = "0x1018AC8", VA = "0x1018AC8")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
