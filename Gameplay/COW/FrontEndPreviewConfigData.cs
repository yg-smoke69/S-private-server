using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002C70")]
public class FrontEndPreviewConfigData : CSVBaseData
{
	[Token(Token = "0x4010F87")]
	[FieldOffset(Offset = "0x8")]
	public FrontendPreviewType FrontendPreviewType;

	[Token(Token = "0x4010F88")]
	[FieldOffset(Offset = "0xC")]
	public string UIFrontEndPreviewItemDescType;

	[Token(Token = "0x4010F89")]
	[FieldOffset(Offset = "0x10")]
	public int CameraDepth;

	[Token(Token = "0x4010F8A")]
	[FieldOffset(Offset = "0x14")]
	public bool IsShowShadow;

	[Token(Token = "0x4010F8B")]
	[FieldOffset(Offset = "0x18")]
	public int Fov;

	[Token(Token = "0x4010F8C")]
	[FieldOffset(Offset = "0x1C")]
	public Vector4 ViewPort;

	[Token(Token = "0x4010F8D")]
	[FieldOffset(Offset = "0x2C")]
	public bool NeedShowUI;

	[Token(Token = "0x4010F8E")]
	[FieldOffset(Offset = "0x2D")]
	public bool NeedCameraMoveBG;

	[Token(Token = "0x4010F8F")]
	[FieldOffset(Offset = "0x2E")]
	public bool NeedDisplayWeaponProperty;

	[Token(Token = "0x4010F90")]
	[FieldOffset(Offset = "0x2F")]
	public bool NeedShow360WeaponModel;

	[Token(Token = "0x4010F91")]
	[FieldOffset(Offset = "0x30")]
	public bool NeedPlayFacialAnim;

	[Token(Token = "0x4010F92")]
	[FieldOffset(Offset = "0x31")]
	public bool NeedEnableLookAt;

	[Token(Token = "0x4010F93")]
	[FieldOffset(Offset = "0x32")]
	public bool NeedModifyAvatarAccordingToResulotion;

	[Token(Token = "0x4010F94")]
	[FieldOffset(Offset = "0x34")]
	public int AvatarLightType;

	[Token(Token = "0x4010F95")]
	[FieldOffset(Offset = "0x38")]
	public bool HideClothWhenPreviewAvatarWithGun;

	[Token(Token = "0x4010F96")]
	[FieldOffset(Offset = "0x3C")]
	public int PreviewConfigIndex;

	[Token(Token = "0x4010F97")]
	[FieldOffset(Offset = "0x40")]
	public bool Preview3dModelNeedAdjustRotate;

	[Token(Token = "0x4010F98")]
	[FieldOffset(Offset = "0x41")]
	public bool AutoShowBoostAvatar;

	[Token(Token = "0x4010F99")]
	[FieldOffset(Offset = "0x42")]
	public bool NeedSpecialIdle;

	[Token(Token = "0x4010F9A")]
	[FieldOffset(Offset = "0x43")]
	public bool NeedDisablePostEffect;

	[Token(Token = "0x4010F9B")]
	[FieldOffset(Offset = "0x44")]
	public bool HasDifferentTypeBg;

	[Token(Token = "0x4010F9C")]
	[FieldOffset(Offset = "0x48")]
	public Vector3 AvatarScale;

	[Token(Token = "0x4010F9D")]
	[FieldOffset(Offset = "0x54")]
	public Vector3 AvatarPos;

	[Token(Token = "0x4010F9E")]
	[FieldOffset(Offset = "0x60")]
	public FrontEndPreviewComponent.AvatarType AvatarType;

	[Token(Token = "0x4010F9F")]
	[FieldOffset(Offset = "0x64")]
	public Vector4 BoostParams;

	[Token(Token = "0x4010FA0")]
	[FieldOffset(Offset = "0x74")]
	public bool PlayPose;

	[Token(Token = "0x4010FA1")]
	[FieldOffset(Offset = "0x75")]
	public bool NeedStopEffect;

	[Token(Token = "0x4010FA2")]
	[FieldOffset(Offset = "0x76")]
	public bool AutoCalculateBoostAvatarParams;

	[Token(Token = "0x601286D")]
	[Address(RVA = "0x104B81C", Offset = "0x104B81C", VA = "0x104B81C")]
	public FrontEndPreviewConfigData()
	{
	}

	[Token(Token = "0x601286E")]
	[Address(RVA = "0x104B8B4", Offset = "0x104B8B4", VA = "0x104B8B4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x601286F")]
	[Address(RVA = "0x104B9B4", Offset = "0x104B9B4", VA = "0x104B9B4", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6012870")]
	[Address(RVA = "0x104C318", Offset = "0x104C318", VA = "0x104C318")]
	public Vector3 TransStringToVector3(string head, string[] headers, string[] values)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6012871")]
	[Address(RVA = "0x104C07C", Offset = "0x104C07C", VA = "0x104C07C")]
	public Vector4 TransStringToVector4(string head, string[] headers, string[] values)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector4);
	}
}
