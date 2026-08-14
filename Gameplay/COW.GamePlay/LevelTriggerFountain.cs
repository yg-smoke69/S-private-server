using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20006C9")]
public class LevelTriggerFountain : MonoBehaviour
{
	[Token(Token = "0x20006CA")]
	public enum CBOODHNHCFN
	{
		[Token(Token = "0x4004AD3")]
		Normal,
		[Token(Token = "0x4004AD4")]
		FixedDirection
	}

	[Token(Token = "0x20006CB")]
	private class BMJJNEKHOOM
	{
		[Token(Token = "0x4004AD5")]
		[FieldOffset(Offset = "0x8")]
		public Queue<float> CPNMMACDHNG;

		[Token(Token = "0x6002B86")]
		[Address(RVA = "0x242B76C", Offset = "0x242B76C", VA = "0x242B76C")]
		public BMJJNEKHOOM()
		{
		}

		[Token(Token = "0x6002B87")]
		[Address(RVA = "0x242B7F8", Offset = "0x242B7F8", VA = "0x242B7F8")]
		public bool FHIPMICEPMI(int BLEAICPKPGL, float OFKLHNEONLD)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4004AC3")]
	[FieldOffset(Offset = "0xC")]
	private GameObject DHFIALBDFEG;

	[Token(Token = "0x4004AC4")]
	[FieldOffset(Offset = "0x10")]
	private ResourceID OBMONKFFGGI;

	[Token(Token = "0x4004AC5")]
	[FieldOffset(Offset = "0x14")]
	public Vector3 direction;

	[Token(Token = "0x4004AC6")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 inputDirection;

	[Token(Token = "0x4004AC7")]
	[FieldOffset(Offset = "0x2C")]
	public float inputSpeed;

	[Token(Token = "0x4004AC8")]
	[FieldOffset(Offset = "0x30")]
	public float speed;

	[Token(Token = "0x4004AC9")]
	[FieldOffset(Offset = "0x34")]
	public bool notAllowInput;

	[Token(Token = "0x4004ACA")]
	[FieldOffset(Offset = "0x38")]
	public int protectCount;

	[Token(Token = "0x4004ACB")]
	[FieldOffset(Offset = "0x3C")]
	public float protectInterval;

	[Token(Token = "0x4004ACC")]
	[FieldOffset(Offset = "0x40")]
	public float protectSpeed;

	[Token(Token = "0x4004ACD")]
	[FieldOffset(Offset = "0x44")]
	public bool hasEffect;

	[Token(Token = "0x4004ACE")]
	[FieldOffset(Offset = "0x48")]
	public Transform ModelContainer;

	[Token(Token = "0x4004ACF")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject WorkshopEditModeVFX;

	[Token(Token = "0x4004AD0")]
	[FieldOffset(Offset = "0x50")]
	private bool KGCHKADJDON;

	[Token(Token = "0x4004AD1")]
	[FieldOffset(Offset = "0x54")]
	private Dictionary<IHAAMHPPLMG, BMJJNEKHOOM> HJIPLNBILJC;

	[Token(Token = "0x6002B7D")]
	[Address(RVA = "0x2429D24", Offset = "0x2429D24", VA = "0x2429D24")]
	public LevelTriggerFountain()
	{
	}

	[Token(Token = "0x6002B7E")]
	[Address(RVA = "0x2429E38", Offset = "0x2429E38", VA = "0x2429E38")]
	protected void Start()
	{
	}

	[Token(Token = "0x6002B7F")]
	[Address(RVA = "0x242A1C8", Offset = "0x242A1C8", VA = "0x242A1C8")]
	protected void Awake()
	{
	}

	[Token(Token = "0x6002B80")]
	[Address(RVA = "0x2429E98", Offset = "0x2429E98", VA = "0x2429E98")]
	private void NKBHINMAHAP()
	{
	}

	[Token(Token = "0x6002B81")]
	[Address(RVA = "0x242AB58", Offset = "0x242AB58", VA = "0x242AB58")]
	public void InitWithData(CJCOHNCPNGG AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6002B82")]
	[Address(RVA = "0x242AE84", Offset = "0x242AE84", VA = "0x242AE84")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x6002B83")]
	[Address(RVA = "0x242A3B0", Offset = "0x242A3B0", VA = "0x242A3B0")]
	private void PCNLJGHCKIH(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6002B84")]
	[Address(RVA = "0x242B140", Offset = "0x242B140", VA = "0x242B140")]
	public Vector3 GetVelocity(Vector3 NDFPNEMGFDB, IHAAMHPPLMG BIFFAIEPIND)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6002B85")]
	[Address(RVA = "0x242B9DC", Offset = "0x242B9DC", VA = "0x242B9DC")]
	public void PlayEffect()
	{
	}
}
