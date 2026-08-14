using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003B68")]
public class HangString : MonoBehaviour
{
	[Token(Token = "0x2003B69")]
	public enum FREEZE_AXIS
	{
		[Token(Token = "0x40194FB")]
		None,
		[Token(Token = "0x40194FC")]
		X,
		[Token(Token = "0x40194FD")]
		Y,
		[Token(Token = "0x40194FE")]
		Z
	}

	[Token(Token = "0x2003B6A")]
	public class STRING
	{
		[Token(Token = "0x40194FF")]
		[FieldOffset(Offset = "0x8")]
		public Transform Trans;

		[Token(Token = "0x4019500")]
		[FieldOffset(Offset = "0xC")]
		public int ParentId;

		[Token(Token = "0x4019501")]
		[FieldOffset(Offset = "0x10")]
		public float Hardness;

		[Token(Token = "0x4019502")]
		[FieldOffset(Offset = "0x14")]
		public float AirResistance;

		[Token(Token = "0x4019503")]
		[FieldOffset(Offset = "0x18")]
		public float Radius;

		[Token(Token = "0x4019504")]
		[FieldOffset(Offset = "0x1C")]
		public float Length;

		[Token(Token = "0x4019505")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 PosNow;

		[Token(Token = "0x4019506")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 PosPrev;

		[Token(Token = "0x4019507")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 InitLocalPos;

		[Token(Token = "0x4019508")]
		[FieldOffset(Offset = "0x44")]
		public Quaternion InitLocalRot;

		[Token(Token = "0x6017A87")]
		[Address(RVA = "0x3514DA8", Offset = "0x3514DA8", VA = "0x3514DA8")]
		public STRING()
		{
		}
	}

	[Token(Token = "0x40194DC")]
	[FieldOffset(Offset = "0xC")]
	public int CalcPriorityId;

	[Token(Token = "0x40194DD")]
	[FieldOffset(Offset = "0x10")]
	public Transform StringFirstBonTrans;

	[Token(Token = "0x40194DE")]
	[FieldOffset(Offset = "0x14")]
	public float Hardness;

	[Token(Token = "0x40194DF")]
	[FieldOffset(Offset = "0x18")]
	public AnimationCurve HardnessCurve;

	[Token(Token = "0x40194E0")]
	[FieldOffset(Offset = "0x1C")]
	public float AirResistance;

	[Token(Token = "0x40194E1")]
	[FieldOffset(Offset = "0x20")]
	public AnimationCurve AirResistanceCurve;

	[Token(Token = "0x40194E2")]
	[FieldOffset(Offset = "0x24")]
	public float StringRad;

	[Token(Token = "0x40194E3")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve StringRadCurve;

	[Token(Token = "0x40194E4")]
	[FieldOffset(Offset = "0x2C")]
	public float StringGravity;

	[Token(Token = "0x40194E5")]
	[FieldOffset(Offset = "0x30")]
	public List<float> NodeGravity;

	[Token(Token = "0x40194E6")]
	[FieldOffset(Offset = "0x34")]
	public List<Transform> ExcludeTrans;

	[Token(Token = "0x40194E7")]
	[FieldOffset(Offset = "0x38")]
	public FREEZE_AXIS FreezeAxis;

	[Token(Token = "0x40194E8")]
	[FieldOffset(Offset = "0x3C")]
	public float FarClipCalcDist;

	[Token(Token = "0x40194E9")]
	[FieldOffset(Offset = "0x40")]
	public List<HangCollider_Sphere> HangCollider_SphereList;

	[Token(Token = "0x40194EA")]
	[FieldOffset(Offset = "0x44")]
	public List<HangCollider_Capsule> HangCollider_CapsuleList;

	[Token(Token = "0x40194EB")]
	[FieldOffset(Offset = "0x48")]
	public List<HangCollider_Plane> HangCollider_PlaneList;

	[Token(Token = "0x40194EC")]
	[FieldOffset(Offset = "0x4C")]
	public bool DBG_AngleLimitDisp;

	[Token(Token = "0x40194ED")]
	[FieldOffset(Offset = "0x50")]
	public ANGLE_LIMIT[] AngleLimit;

	[Token(Token = "0x40194EE")]
	[FieldOffset(Offset = "0x54")]
	public float FirstBoneRotZOffset;

	[Token(Token = "0x40194EF")]
	[FieldOffset(Offset = "0x58")]
	private float[] InitSpringLength;

	[Token(Token = "0x40194F0")]
	[FieldOffset(Offset = "0x5C")]
	private float s_StringTotalLength;

	[Token(Token = "0x40194F1")]
	[FieldOffset(Offset = "0x60")]
	private float s_ObjectScale;

	[Token(Token = "0x40194F2")]
	[FieldOffset(Offset = "0x64")]
	private bool s_DistantDisabled;

	[Token(Token = "0x40194F3")]
	[FieldOffset(Offset = "0x65")]
	private bool s_TeleportFlag;

	[Token(Token = "0x40194F4")]
	[FieldOffset(Offset = "0x68")]
	private int s_Start_SetupFrameCount;

	[Token(Token = "0x40194F5")]
	[FieldOffset(Offset = "0x6C")]
	private bool s_Start_SetupOnceFlag;

	[Token(Token = "0x40194F6")]
	[FieldOffset(Offset = "0x70")]
	private int s_Start_ResetKeepFrameCount;

	[Token(Token = "0x40194F7")]
	[FieldOffset(Offset = "0x74")]
	private List<STRING> String;

	[Token(Token = "0x40194F8")]
	[FieldOffset(Offset = "0x78")]
	private HangManager script_HangManager;

	[Token(Token = "0x40194F9")]
	[FieldOffset(Offset = "0x7C")]
	private bool IsNeedUpdate;

	[Token(Token = "0x6017A6D")]
	[Address(RVA = "0x3511600", Offset = "0x3511600", VA = "0x3511600")]
	public HangString()
	{
	}

	[Token(Token = "0x6017A6E")]
	[Address(RVA = "0x35117A4", Offset = "0x35117A4", VA = "0x35117A4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6017A6F")]
	[Address(RVA = "0x350FBD0", Offset = "0x350FBD0", VA = "0x350FBD0")]
	public void LateUpdateCalc(bool isNeedUpdate, float deltaTime)
	{
	}

	[Token(Token = "0x6017A70")]
	[Address(RVA = "0x3511994", Offset = "0x3511994", VA = "0x3511994")]
	private void FarClipCalc()
	{
	}

	[Token(Token = "0x6017A71")]
	[Address(RVA = "0x3511CA0", Offset = "0x3511CA0", VA = "0x3511CA0")]
	private void StringPos2ModelPos()
	{
	}

	[Token(Token = "0x6017A72")]
	[Address(RVA = "0x3510294", Offset = "0x3510294", VA = "0x3510294")]
	public void LocalTransInit()
	{
	}

	[Token(Token = "0x6017A73")]
	[Address(RVA = "0x3511DF8", Offset = "0x3511DF8", VA = "0x3511DF8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6017A74")]
	[Address(RVA = "0x3511DFC", Offset = "0x3511DFC", VA = "0x3511DFC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6017A75")]
	[Address(RVA = "0x3511E00", Offset = "0x3511E00", VA = "0x3511E00")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6017A76")]
	[Address(RVA = "0x3511B28", Offset = "0x3511B28", VA = "0x3511B28")]
	private void StringCalc(float Dt)
	{
	}

	[Token(Token = "0x6017A77")]
	[Address(RVA = "0x3510448", Offset = "0x3510448", VA = "0x3510448")]
	public void StringSetup()
	{
	}

	[Token(Token = "0x6017A78")]
	[Address(RVA = "0x3514344", Offset = "0x3514344", VA = "0x3514344")]
	private void AddStringNode(Transform Trans, int ParentId, float Length)
	{
	}

	[Token(Token = "0x6017A79")]
	[Address(RVA = "0x3514A70", Offset = "0x3514A70", VA = "0x3514A70")]
	private void UpdateParam()
	{
	}

	[Token(Token = "0x6017A7A")]
	[Address(RVA = "0x3511F04", Offset = "0x3511F04", VA = "0x3511F04")]
	private void StringCalcSub_1_FirstBone()
	{
	}

	[Token(Token = "0x6017A7B")]
	[Address(RVA = "0x3511FF4", Offset = "0x3511FF4", VA = "0x3511FF4")]
	private void StringCalcSub_2_WindAndMove(float Dt)
	{
	}

	[Token(Token = "0x6017A7C")]
	[Address(RVA = "0x3512F90", Offset = "0x3512F90", VA = "0x3512F90")]
	private void StringCalcSub_3_LimitAndTransform()
	{
	}

	[Token(Token = "0x6017A7D")]
	[Address(RVA = "0x35134D4", Offset = "0x35134D4", VA = "0x35134D4")]
	private void StringCalcSub_4_ColiHit()
	{
	}

	[Token(Token = "0x6017A7E")]
	[Address(RVA = "0x3513EFC", Offset = "0x3513EFC", VA = "0x3513EFC")]
	private void StringCalcSub_5_Trans()
	{
	}

	[Token(Token = "0x6017A7F")]
	[Address(RVA = "0x3514EDC", Offset = "0x3514EDC", VA = "0x3514EDC")]
	private void AngleLimit_YZ(int NodeId)
	{
	}

	[Token(Token = "0x6017A80")]
	[Address(RVA = "0x350FE04", Offset = "0x350FE04", VA = "0x350FE04")]
	public void StringReset()
	{
	}

	[Token(Token = "0x6017A81")]
	[Address(RVA = "0x3510130", Offset = "0x3510130", VA = "0x3510130")]
	public void Teleport()
	{
	}

	[Token(Token = "0x6017A82")]
	[Address(RVA = "0x3515F00", Offset = "0x3515F00", VA = "0x3515F00")]
	public void ClearCollider(GameObject rootGameObject)
	{
	}

	[Token(Token = "0x6017A83")]
	[Address(RVA = "0x3516018", Offset = "0x3516018", VA = "0x3516018")]
	public void DeserializeCollider(GameObject rootGameObject, HangStringProperty property)
	{
	}

	[Token(Token = "0x6017A84")]
	[Address(RVA = "0x35170F8", Offset = "0x35170F8", VA = "0x35170F8")]
	public void Deserialize(GameObject rootGameObject, HangStringProperty se)
	{
	}

	[Token(Token = "0x6017A85")]
	[Address(RVA = "0x3517408", Offset = "0x3517408", VA = "0x3517408")]
	public void DeserializeAngleLimit(GameObject rootGameObject, List<ANGLELIMIT_PROPERTY> properties)
	{
	}

	[Token(Token = "0x6017A86")]
	[Address(RVA = "0x35178D8", Offset = "0x35178D8", VA = "0x35178D8")]
	private Transform GetPivotTransform(GameObject rootGameObject, string BaseAxis, string BaseAxisParent, Quaternion BaseAxis_quaternion)
	{
		return null;
	}
}
