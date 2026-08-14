using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20025AE")]
public class UICreateCharacterController : UIBaseController, _Attribute
{
	[Token(Token = "0x20025AF")]
	public enum ErrorNameType
	{
		[Token(Token = "0x400E903")]
		DuplicateName,
		[Token(Token = "0x400E904")]
		DirtyName
	}

	[Token(Token = "0x400E8F9")]
	[FieldOffset(Offset = "0x28")]
	private UICreateCharacterView m_View;

	[Token(Token = "0x400E8FA")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_AvatarId;

	[Token(Token = "0x400E8FB")]
	private const string m_EnterAnimName = "FF_Renamed_Admission_ani";

	[Token(Token = "0x400E8FC")]
	private const string m_ExitAnimName = "FF_Renamed_Appearance_ani";

	[Token(Token = "0x400E8FD")]
	[FieldOffset(Offset = "0x30")]
	private uint m_DelayCallFinishHide;

	[Token(Token = "0x400E8FE")]
	[FieldOffset(Offset = "0x34")]
	private float m_FinishWaitingDuration;

	[Token(Token = "0x400E8FF")]
	[FieldOffset(Offset = "0x38")]
	private string m_UserInputName;

	[Token(Token = "0x400E900")]
	[FieldOffset(Offset = "0x3C")]
	private uint m_AvatarIdTmp;

	[Token(Token = "0x400E901")]
	[FieldOffset(Offset = "0x0")]
	private static Func<char, bool> _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x600DC8D")]
	[Address(RVA = "0x1EC3F28", Offset = "0x1EC3F28", VA = "0x1EC3F28")]
	public UICreateCharacterController()
	{
	}

	[Token(Token = "0x600DC8E")]
	[Address(RVA = "0x1EC4000", Offset = "0x1EC4000", VA = "0x1EC4000")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DC8F")]
	[Address(RVA = "0x1EC40A4", Offset = "0x1EC40A4", VA = "0x1EC40A4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DC90")]
	[Address(RVA = "0x1EC4698", Offset = "0x1EC4698", VA = "0x1EC4698", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600DC91")]
	[Address(RVA = "0x1EC47B4", Offset = "0x1EC47B4", VA = "0x1EC47B4")]
	public void PlayEnterAnim()
	{
	}

	[Token(Token = "0x600DC92")]
	[Address(RVA = "0x1EC488C", Offset = "0x1EC488C", VA = "0x1EC488C")]
	public void FinishAndClose()
	{
	}

	[Token(Token = "0x600DC93")]
	[Address(RVA = "0x1EC4D84", Offset = "0x1EC4D84", VA = "0x1EC4D84")]
	private void OnInputChange()
	{
	}

	[Token(Token = "0x600DC94")]
	[Address(RVA = "0x1EC5288", Offset = "0x1EC5288", VA = "0x1EC5288")]
	private void SetNickNameErrMessage(string errMessage)
	{
	}

	[Token(Token = "0x600DC95")]
	[Address(RVA = "0x1EC54A8", Offset = "0x1EC54A8", VA = "0x1EC54A8")]
	private void OnRegisterClick()
	{
	}

	[Token(Token = "0x600DC96")]
	[Address(RVA = "0x1EC5C2C", Offset = "0x1EC5C2C", VA = "0x1EC5C2C")]
	public void OnGenerateNickName(object[] param)
	{
	}

	[Token(Token = "0x600DC97")]
	[Address(RVA = "0x1EC5D4C", Offset = "0x1EC5D4C", VA = "0x1EC5D4C")]
	public void OnErrorUsername(object[] param)
	{
	}

	[Token(Token = "0x600DC98")]
	[Address(RVA = "0x1EC6444", Offset = "0x1EC6444", VA = "0x1EC6444")]
	private void OnUseClick()
	{
	}

	[Token(Token = "0x600DC99")]
	[Address(RVA = "0x1EC4578", Offset = "0x1EC4578", VA = "0x1EC4578")]
	public void CreateRandomName()
	{
	}

	[Token(Token = "0x600DC9A")]
	[Address(RVA = "0x1EC64F4", Offset = "0x1EC64F4", VA = "0x1EC64F4", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600DC9B")]
	[Address(RVA = "0x1EC65F0", Offset = "0x1EC65F0", VA = "0x1EC65F0", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600DC9C")]
	[Address(RVA = "0x1EC6684", Offset = "0x1EC6684", VA = "0x1EC6684")]
	private void _003CFinishAndClose_003Em__0()
	{
	}

	[Token(Token = "0x600DC9D")]
	[Address(RVA = "0x1EC6728", Offset = "0x1EC6728", VA = "0x1EC6728")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DC9E")]
	[Address(RVA = "0x1EC6730", Offset = "0x1EC6730", VA = "0x1EC6730")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
