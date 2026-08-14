using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003B64")]
public class HangManager : MonoBehaviour
{
	[Token(Token = "0x2003B65")]
	public enum LANGUAGE_TYPE
	{
		[Token(Token = "0x40194CD")]
		JAPAN,
		[Token(Token = "0x40194CE")]
		ENGLISH,
		[Token(Token = "0x40194CF")]
		CHINESE
	}

	[Token(Token = "0x40194B9")]
	[FieldOffset(Offset = "0xC")]
	public LANGUAGE_TYPE LanguageType;

	[Token(Token = "0x40194BA")]
	[FieldOffset(Offset = "0x10")]
	public Transform FarClippingObjRef;

	[Token(Token = "0x40194BB")]
	[FieldOffset(Offset = "0x14")]
	public float UpdateRate;

	[Token(Token = "0x40194BC")]
	[FieldOffset(Offset = "0x18")]
	public int StartResetWaitFrame;

	[Token(Token = "0x40194BD")]
	[FieldOffset(Offset = "0x1C")]
	public Vector3 WindVec;

	[Token(Token = "0x40194BE")]
	[FieldOffset(Offset = "0x28")]
	public float WindPower;

	[Token(Token = "0x40194BF")]
	[FieldOffset(Offset = "0x2C")]
	public float WindRotAdd;

	[Token(Token = "0x40194C0")]
	[FieldOffset(Offset = "0x30")]
	public bool WindRandFlag;

	[Token(Token = "0x40194C1")]
	[FieldOffset(Offset = "0x31")]
	public bool WindIntermittentMassFlag;

	[Token(Token = "0x40194C2")]
	[FieldOffset(Offset = "0x32")]
	public bool CalcFlag;

	[Token(Token = "0x40194C3")]
	[FieldOffset(Offset = "0x33")]
	public bool CalcHangTransCopyOnlyFlag;

	[Token(Token = "0x40194C4")]
	[FieldOffset(Offset = "0x34")]
	public bool DBG_DispFlag;

	[Token(Token = "0x40194C5")]
	[FieldOffset(Offset = "0x38")]
	public float Duration;

	[Token(Token = "0x40194C6")]
	[FieldOffset(Offset = "0x3C")]
	public int SetupFrameCount;

	[Token(Token = "0x40194C7")]
	[FieldOffset(Offset = "0x40")]
	public int ResetKeepFrameCount;

	[NonSerialized]
	[Token(Token = "0x40194C8")]
	[FieldOffset(Offset = "0x44")]
	private int ResetCount;

	[Token(Token = "0x40194C9")]
	[FieldOffset(Offset = "0x48")]
	private GameObject HangObj;

	[Token(Token = "0x40194CA")]
	[FieldOffset(Offset = "0x4C")]
	private HangString[] children;

	[Token(Token = "0x40194CB")]
	[FieldOffset(Offset = "0x50")]
	private float TimePass;

	[Token(Token = "0x6017A4F")]
	[Address(RVA = "0x350F594", Offset = "0x350F594", VA = "0x350F594")]
	public HangManager()
	{
	}

	[Token(Token = "0x6017A50")]
	[Address(RVA = "0x350F614", Offset = "0x350F614", VA = "0x350F614")]
	private void Start()
	{
	}

	[Token(Token = "0x6017A51")]
	[Address(RVA = "0x350F6F8", Offset = "0x350F6F8", VA = "0x350F6F8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6017A52")]
	[Address(RVA = "0x350FCB0", Offset = "0x350FCB0", VA = "0x350FCB0")]
	private void HangReset()
	{
	}

	[Token(Token = "0x6017A53")]
	[Address(RVA = "0x350FE34", Offset = "0x350FE34", VA = "0x350FE34")]
	public void HangStringDelivery(LANGUAGE_TYPE LanguageType)
	{
	}

	[Token(Token = "0x6017A54")]
	[Address(RVA = "0x350FFE4", Offset = "0x350FFE4", VA = "0x350FFE4")]
	public void HangResetRequest(int WaitFrame)
	{
	}

	[Token(Token = "0x6017A55")]
	[Address(RVA = "0x350F534", Offset = "0x350F534", VA = "0x350F534")]
	public void WindSet(Vector3 Vec, float Power, bool RandFlag, bool IntermittentMassFlag)
	{
	}

	[Token(Token = "0x6017A56")]
	[Address(RVA = "0x350FFF4", Offset = "0x350FFF4", VA = "0x350FFF4")]
	public void Teleport()
	{
	}

	[Token(Token = "0x6017A57")]
	[Address(RVA = "0x351013C", Offset = "0x351013C", VA = "0x351013C")]
	public void StringSetup()
	{
	}

	[Token(Token = "0x6017A58")]
	[Address(RVA = "0x351076C", Offset = "0x351076C", VA = "0x351076C")]
	public void ResetChildren()
	{
	}

	[Token(Token = "0x6017A59")]
	[Address(RVA = "0x3510848", Offset = "0x3510848", VA = "0x3510848")]
	public void CalcFlagOn()
	{
	}

	[Token(Token = "0x6017A5A")]
	[Address(RVA = "0x3510854", Offset = "0x3510854", VA = "0x3510854")]
	public void CalcFlagOff()
	{
	}

	[Token(Token = "0x6017A5B")]
	[Address(RVA = "0x3510860", Offset = "0x3510860", VA = "0x3510860")]
	public void CalcHangTransCopyOnlyFlagOn()
	{
	}

	[Token(Token = "0x6017A5C")]
	[Address(RVA = "0x351086C", Offset = "0x351086C", VA = "0x351086C")]
	public void CalcHangTransCopyOnlyFlagOff()
	{
	}

	[Token(Token = "0x6017A5D")]
	[Address(RVA = "0x3510878", Offset = "0x3510878", VA = "0x3510878")]
	public bool IsCalcFlag()
	{
		return default(bool);
	}

	[Token(Token = "0x6017A5E")]
	[Address(RVA = "0x3510880", Offset = "0x3510880", VA = "0x3510880")]
	public static float CalcInter(float v1, float v2, float t)
	{
		return default(float);
	}

	[Token(Token = "0x6017A5F")]
	[Address(RVA = "0x35108A8", Offset = "0x35108A8", VA = "0x35108A8")]
	public static float CalcReducedScaleChangeNoLimit(float defult_len, float change_over_len, float alpha)
	{
		return default(float);
	}

	[Token(Token = "0x6017A60")]
	[Address(RVA = "0x35108DC", Offset = "0x35108DC", VA = "0x35108DC")]
	private static float CalcSpherePlateDist(Vector3 pos, Vector3 nml, float coef_d)
	{
		return default(float);
	}

	[Token(Token = "0x6017A61")]
	[Address(RVA = "0x350E8E0", Offset = "0x350E8E0", VA = "0x350E8E0")]
	public static void CalcPlateNodePerpendicular(Vector3 c_pos, out Vector3 dst, Vector3 p0, Vector3 nml)
	{
	}

	[Token(Token = "0x6017A62")]
	[Address(RVA = "0x350E7A4", Offset = "0x350E7A4", VA = "0x350E7A4")]
	public static int CalcTriangle3DWrongSideOutNormal(Vector3 node, Vector3 l_node, Vector3 nml)
	{
		return default(int);
	}

	[Token(Token = "0x6017A63")]
	[Address(RVA = "0x350DEF4", Offset = "0x350DEF4", VA = "0x350DEF4")]
	public static void CalcSphereHit(ref Vector3 StringPos, float StringRad, Vector3 SpherePos, float SphereRad)
	{
	}

	[Token(Token = "0x6017A64")]
	[Address(RVA = "0x350E09C", Offset = "0x350E09C", VA = "0x350E09C")]
	public static void CalcCapsuleHit(ref Vector3 StringPos, float StringRad, Vector3 CapsulePos_0, Vector3 CapsulePos_1, float CapsuleRad)
	{
	}

	[Token(Token = "0x6017A65")]
	[Address(RVA = "0x35109BC", Offset = "0x35109BC", VA = "0x35109BC")]
	public static Matrix4x4 CreateMatrix(Vector3 x, Vector3 y, Vector3 z, Vector3 t)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Matrix4x4);
	}

	[Token(Token = "0x6017A66")]
	[Address(RVA = "0x3510BC4", Offset = "0x3510BC4", VA = "0x3510BC4")]
	public static Quaternion Matrix2Quaternion(Matrix4x4 m)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Quaternion);
	}

	[Token(Token = "0x6017A67")]
	[Address(RVA = "0x3510FF8", Offset = "0x3510FF8", VA = "0x3510FF8")]
	private static float Determinant(Matrix4x4 m)
	{
		return default(float);
	}

	[Token(Token = "0x6017A68")]
	[Address(RVA = "0x351119C", Offset = "0x351119C", VA = "0x351119C")]
	public static Vector3 VectorRot(Vector3 VecSide, Vector3 VecForward, float Deg)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6017A69")]
	[Address(RVA = "0x35112F0", Offset = "0x35112F0", VA = "0x35112F0")]
	public static float CalcSinTblGet(float x1, float x2, float rot)
	{
		return default(float);
	}

	[Token(Token = "0x6017A6A")]
	[Address(RVA = "0x35113AC", Offset = "0x35113AC", VA = "0x35113AC")]
	public static void Anglelimit(Vector3 SideVec, Vector3 UpVec, Vector3 ForwardVec, float AngleMin, float AngleMax, ref Vector3 NodePos)
	{
	}
}
