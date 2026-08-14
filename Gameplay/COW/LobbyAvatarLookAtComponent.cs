using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001FBF")]
public class LobbyAvatarLookAtComponent : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2001FC0")]
	public class BaseParam
	{
		[Token(Token = "0x400C73D")]
		[FieldOffset(Offset = "0x8")]
		public float angleMin;

		[Token(Token = "0x400C73E")]
		[FieldOffset(Offset = "0xC")]
		public float angleMax;

		[Token(Token = "0x400C73F")]
		[FieldOffset(Offset = "0x10")]
		public float angleInMin;

		[Token(Token = "0x400C740")]
		[FieldOffset(Offset = "0x14")]
		public float angleInMax;

		[Token(Token = "0x400C741")]
		[FieldOffset(Offset = "0x18")]
		public float turnSpeed;

		[Token(Token = "0x400C742")]
		[FieldOffset(Offset = "0x1C")]
		public float inLerpSpeed;

		[Token(Token = "0x400C743")]
		[FieldOffset(Offset = "0x20")]
		public float NewFrameAngleWeight;

		[Token(Token = "0x400C744")]
		[FieldOffset(Offset = "0x24")]
		public bool UseSpeedCurve;

		[Token(Token = "0x400C745")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve AngleToSpeed;

		[Token(Token = "0x6009ECD")]
		[Address(RVA = "0xECDDF0", Offset = "0xECDDF0", VA = "0xECDDF0")]
		public BaseParam()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2001FC1")]
	public class HeadParam : BaseParam
	{
		[Token(Token = "0x400C746")]
		[FieldOffset(Offset = "0x2C")]
		public float neckRatio;

		[Token(Token = "0x6009ECE")]
		[Address(RVA = "0xECD6B0", Offset = "0xECD6B0", VA = "0xECD6B0")]
		public HeadParam()
		{
		}
	}

	[Token(Token = "0x2001FC2")]
	private class BaseState
	{
		[Token(Token = "0x400C747")]
		[FieldOffset(Offset = "0x8")]
		public int m_LastFrame;

		[Token(Token = "0x400C748")]
		[FieldOffset(Offset = "0xC")]
		public float m_LastFrameAngles;

		[Token(Token = "0x400C749")]
		[FieldOffset(Offset = "0x10")]
		public float m_lastAngle;

		[Token(Token = "0x400C74A")]
		[FieldOffset(Offset = "0x14")]
		public float m_curAngle;

		[Token(Token = "0x6009ECF")]
		[Address(RVA = "0xECF4BC", Offset = "0xECF4BC", VA = "0xECF4BC")]
		public BaseState()
		{
		}
	}

	[Token(Token = "0x2001FC3")]
	private class HeadState : BaseState
	{
		[Token(Token = "0x400C74B")]
		[FieldOffset(Offset = "0x18")]
		public float m_curNeck;

		[Token(Token = "0x400C74C")]
		[FieldOffset(Offset = "0x1C")]
		public float m_tarNeck;

		[Token(Token = "0x400C74D")]
		[FieldOffset(Offset = "0x20")]
		public float m_curSpine1;

		[Token(Token = "0x400C74E")]
		[FieldOffset(Offset = "0x24")]
		public float m_tarSpine1;

		[Token(Token = "0x6009ED0")]
		[Address(RVA = "0xECDA30", Offset = "0xECDA30", VA = "0xECDA30")]
		public HeadState()
		{
		}
	}

	[Token(Token = "0x2001FC4")]
	private class EyesState : BaseState
	{
		[Token(Token = "0x400C74F")]
		[FieldOffset(Offset = "0x18")]
		public float m_curEye;

		[Token(Token = "0x400C750")]
		[FieldOffset(Offset = "0x1C")]
		public float m_tarEye;

		[Token(Token = "0x6009ED1")]
		[Address(RVA = "0xECE168", Offset = "0xECE168", VA = "0xECE168")]
		public EyesState()
		{
		}
	}

	[Token(Token = "0x400C71E")]
	[FieldOffset(Offset = "0xC")]
	public float angleMin;

	[Token(Token = "0x400C71F")]
	[FieldOffset(Offset = "0x10")]
	public float angleMax;

	[Token(Token = "0x400C720")]
	[FieldOffset(Offset = "0x14")]
	public float angleInMin;

	[Token(Token = "0x400C721")]
	[FieldOffset(Offset = "0x18")]
	public float angleInMax;

	[Token(Token = "0x400C722")]
	[FieldOffset(Offset = "0x1C")]
	public float turnSpeed;

	[Token(Token = "0x400C723")]
	[FieldOffset(Offset = "0x20")]
	public float inLerpSpeed;

	[Token(Token = "0x400C724")]
	[FieldOffset(Offset = "0x24")]
	public float NewFrameAngleWeight;

	[Token(Token = "0x400C725")]
	[FieldOffset(Offset = "0x28")]
	private float m_DefaultAngleMin;

	[Token(Token = "0x400C726")]
	[FieldOffset(Offset = "0x2C")]
	private float m_DefaultAngleMax;

	[Token(Token = "0x400C727")]
	[FieldOffset(Offset = "0x30")]
	private float m_DefaultAngleInMin;

	[Token(Token = "0x400C728")]
	[FieldOffset(Offset = "0x34")]
	private float m_DefaultAngleInMax;

	[Token(Token = "0x400C729")]
	[FieldOffset(Offset = "0x38")]
	private float m_DefaultTurnSpeed;

	[Token(Token = "0x400C72A")]
	[FieldOffset(Offset = "0x3C")]
	private float m_DefaultInLerpSpeed;

	[Token(Token = "0x400C72B")]
	[FieldOffset(Offset = "0x40")]
	private float m_DefaultNewFrameAngleWeight;

	[Token(Token = "0x400C72C")]
	[FieldOffset(Offset = "0x44")]
	private Animator m_Animator;

	[Token(Token = "0x400C72D")]
	[FieldOffset(Offset = "0x48")]
	private Transform m_character;

	[Token(Token = "0x400C72E")]
	[FieldOffset(Offset = "0x0")]
	private static HashSet<int> m_Idle;

	[Token(Token = "0x400C72F")]
	[FieldOffset(Offset = "0x4C")]
	public bool RotHead;

	[Token(Token = "0x400C730")]
	[FieldOffset(Offset = "0x50")]
	public HeadParam HeadParams;

	[Token(Token = "0x400C731")]
	[FieldOffset(Offset = "0x54")]
	private HeadState HeadStates;

	[Token(Token = "0x400C732")]
	[FieldOffset(Offset = "0x58")]
	private Transform m_boneNeck;

	[Token(Token = "0x400C733")]
	[FieldOffset(Offset = "0x5C")]
	private Transform m_boneSpine1;

	[Token(Token = "0x400C734")]
	[FieldOffset(Offset = "0x60")]
	public bool RotEyes;

	[Token(Token = "0x400C735")]
	[FieldOffset(Offset = "0x64")]
	public BaseParam LeftEyeParams;

	[Token(Token = "0x400C736")]
	[FieldOffset(Offset = "0x68")]
	public BaseParam RightEyeParams;

	[Token(Token = "0x400C737")]
	[FieldOffset(Offset = "0x6C")]
	private EyesState LeftEyeStates;

	[Token(Token = "0x400C738")]
	[FieldOffset(Offset = "0x70")]
	private EyesState RightEyeStates;

	[Token(Token = "0x400C739")]
	[FieldOffset(Offset = "0x74")]
	private Transform m_boneEyeL;

	[Token(Token = "0x400C73A")]
	[FieldOffset(Offset = "0x78")]
	private Transform m_boneEyeR;

	[Token(Token = "0x400C73B")]
	[FieldOffset(Offset = "0x7C")]
	private Transform m_3DCamera;

	[Token(Token = "0x400C73C")]
	[FieldOffset(Offset = "0x80")]
	private int m_UIType;

	[Token(Token = "0x6009EBA")]
	[Address(RVA = "0xECC6A8", Offset = "0xECC6A8", VA = "0xECC6A8")]
	public LobbyAvatarLookAtComponent()
	{
	}

	[Token(Token = "0x6009EBB")]
	[Address(RVA = "0xECC730", Offset = "0xECC730", VA = "0xECC730")]
	private void Start()
	{
	}

	[Token(Token = "0x6009EBC")]
	[Address(RVA = "0xECCC24", Offset = "0xECCC24", VA = "0xECCC24")]
	public void Init(CSSharedAvatarData aData, AvatarLookAtData ldata, int uiType = -1, [Optional] FrontEndPreviewComponent frontEndPreviewComponent)
	{
	}

	[Token(Token = "0x6009EBD")]
	[Address(RVA = "0xECD070", Offset = "0xECD070", VA = "0xECD070")]
	public void Init(bool enable)
	{
	}

	[Token(Token = "0x6009EBE")]
	[Address(RVA = "0xECD560", Offset = "0xECD560", VA = "0xECD560")]
	private void InitHeadParams()
	{
	}

	[Token(Token = "0x6009EBF")]
	[Address(RVA = "0xECD708", Offset = "0xECD708", VA = "0xECD708")]
	private void InitHeadCurve(ref AnimationCurve AngleToSpeed)
	{
	}

	[Token(Token = "0x6009EC0")]
	[Address(RVA = "0xECD368", Offset = "0xECD368", VA = "0xECD368")]
	private void InitEyesLookAt(bool enable)
	{
	}

	[Token(Token = "0x6009EC1")]
	[Address(RVA = "0xECDA38", Offset = "0xECDA38", VA = "0xECDA38")]
	private void InitEyesParams()
	{
	}

	[Token(Token = "0x6009EC2")]
	[Address(RVA = "0xECDE40", Offset = "0xECDE40", VA = "0xECDE40")]
	private void InitEyesCurve(ref AnimationCurve AngleToSpeed)
	{
	}

	[Token(Token = "0x6009EC3")]
	[Address(RVA = "0xECE170", Offset = "0xECE170", VA = "0xECE170")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6009EC4")]
	[Address(RVA = "0xECE420", Offset = "0xECE420", VA = "0xECE420")]
	private bool CheckAnimState()
	{
		return default(bool);
	}

	[Token(Token = "0x6009EC5")]
	[Address(RVA = "0xECE598", Offset = "0xECE598", VA = "0xECE598")]
	private void UpdateHeadState(HeadParam p, HeadState s, bool animStateOk, float characterY)
	{
	}

	[Token(Token = "0x6009EC6")]
	[Address(RVA = "0xECE9C8", Offset = "0xECE9C8", VA = "0xECE9C8")]
	private void UpdateEyesState(BaseParam p, EyesState s, bool animStateOk, float characterY)
	{
	}

	[Token(Token = "0x6009EC7")]
	[Address(RVA = "0xECEB98", Offset = "0xECEB98", VA = "0xECEB98")]
	private float UpdateBaseState(BaseParam p, BaseState s, bool animStateOk, float localEulerAngle, bool isHead)
	{
		return default(float);
	}

	[Token(Token = "0x6009EC8")]
	[Address(RVA = "0xECF31C", Offset = "0xECF31C", VA = "0xECF31C")]
	private static bool IsPortraitView()
	{
		return default(bool);
	}

	[Token(Token = "0x6009EC9")]
	[Address(RVA = "0xECF088", Offset = "0xECF088", VA = "0xECF088")]
	private static void LerpToTargetByCurve(ref float cur, ref float tar, float scale, AnimationCurve angleToSpeed)
	{
	}

	[Token(Token = "0x6009ECA")]
	[Address(RVA = "0xECF1F0", Offset = "0xECF1F0", VA = "0xECF1F0")]
	private static void LerpToTarget(ref float cur, ref float tar, float step)
	{
	}

	[Token(Token = "0x6009ECB")]
	[Address(RVA = "0xECE7EC", Offset = "0xECE7EC", VA = "0xECE7EC")]
	private static void RotateTransform(Transform tr, float angle)
	{
	}
}
