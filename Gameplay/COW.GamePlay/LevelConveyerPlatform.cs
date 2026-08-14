using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000603")]
public class LevelConveyerPlatform : LevelMovePlatform
{
	[Token(Token = "0x2000604")]
	public enum KAGAJNALPMJ
	{
		[Token(Token = "0x4004568")]
		Direct,
		[Token(Token = "0x4004569")]
		Rotate
	}

	[Token(Token = "0x4004559")]
	[FieldOffset(Offset = "0x90")]
	public int CurPointIndex;

	[Token(Token = "0x400455A")]
	[FieldOffset(Offset = "0x94")]
	public float NextMoveTime;

	[Token(Token = "0x400455B")]
	[FieldOffset(Offset = "0x98")]
	public int CentreIndex;

	[Token(Token = "0x400455C")]
	[FieldOffset(Offset = "0x9C")]
	public float PerRoundTime;

	[Token(Token = "0x400455D")]
	[FieldOffset(Offset = "0xA0")]
	public float StartMoment;

	[Token(Token = "0x400455E")]
	[FieldOffset(Offset = "0xA4")]
	public float DirectSpeed;

	[Token(Token = "0x400455F")]
	[FieldOffset(Offset = "0xA8")]
	public float EdgeSpeed;

	[Token(Token = "0x4004560")]
	[FieldOffset(Offset = "0xAC")]
	public List<Vector3> EdgePoints;

	[Token(Token = "0x4004561")]
	[FieldOffset(Offset = "0xB0")]
	public Vector3[] CentrePoints;

	[Token(Token = "0x4004562")]
	[FieldOffset(Offset = "0xB4")]
	public float[] MoveTimeArray;

	[Token(Token = "0x4004563")]
	[FieldOffset(Offset = "0xB8")]
	public bool IsDebug;

	[Token(Token = "0x4004564")]
	[FieldOffset(Offset = "0xBC")]
	private float DJGOFIKNCDI;

	[Token(Token = "0x4004565")]
	[FieldOffset(Offset = "0xC0")]
	public KAGAJNALPMJ State;

	[Token(Token = "0x4004566")]
	[FieldOffset(Offset = "0xC4")]
	public bool IsInit;

	[Token(Token = "0x60024F6")]
	[Address(RVA = "0x270B048", Offset = "0x270B048", VA = "0x270B048")]
	public LevelConveyerPlatform()
	{
	}

	[Token(Token = "0x60024F7")]
	[Address(RVA = "0x270B05C", Offset = "0x270B05C", VA = "0x270B05C", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x60024F8")]
	[Address(RVA = "0x270B100", Offset = "0x270B100", VA = "0x270B100")]
	public uint GetPlatformId()
	{
		return default(uint);
	}

	[Token(Token = "0x60024F9")]
	[Address(RVA = "0x270B214", Offset = "0x270B214", VA = "0x270B214", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x60024FA")]
	[Address(RVA = "0x270B498", Offset = "0x270B498", VA = "0x270B498", Slot = "16")]
	protected override void OnOnDestroy()
	{
	}

	[Token(Token = "0x60024FB")]
	[Address(RVA = "0x270B4EC", Offset = "0x270B4EC", VA = "0x270B4EC")]
	protected void Start()
	{
	}

	[Token(Token = "0x60024FC")]
	[Address(RVA = "0x270B54C", Offset = "0x270B54C", VA = "0x270B54C")]
	protected void OLKDBDEIJMK()
	{
	}

	[Token(Token = "0x60024FD")]
	[Address(RVA = "0x270B748", Offset = "0x270B748", VA = "0x270B748")]
	public void RegisterPlatformIfNeed()
	{
	}

	[Token(Token = "0x60024FE")]
	[Address(RVA = "0x270B868", Offset = "0x270B868", VA = "0x270B868")]
	private void OnApplicationPause(bool IEHLJGPHGLM)
	{
	}

	[Token(Token = "0x60024FF")]
	[Address(RVA = "0x270B8CC", Offset = "0x270B8CC", VA = "0x270B8CC")]
	public void CheckNetSyncState()
	{
	}

	[Token(Token = "0x6002500")]
	[Address(RVA = "0x270BACC", Offset = "0x270BACC", VA = "0x270BACC")]
	public void UpdateTransformByTime()
	{
	}

	[Token(Token = "0x6002501")]
	[Address(RVA = "0x270C880", Offset = "0x270C880", VA = "0x270C880", Slot = "17")]
	public override void OnFixedUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002502")]
	[Address(RVA = "0x270C990", Offset = "0x270C990", VA = "0x270C990")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6002503")]
	[Address(RVA = "0x270D0D4", Offset = "0x270D0D4", VA = "0x270D0D4")]
	public void FillPlatformPara(float MIACFIALLFP, float KFBCIPINJOC, float GKKODDJNIMJ, List<Vector3> LHOINOFLHHG, Vector3[] LIHNLINJMDL, float[] KLLOEEPADNN, float FPDAMNMBDGI)
	{
	}

	[Token(Token = "0x6002504")]
	[Address(RVA = "0x270D1C8", Offset = "0x270D1C8", VA = "0x270D1C8")]
	public void SetTag()
	{
	}

	[Token(Token = "0x6002505")]
	[Address(RVA = "0x270C698", Offset = "0x270C698", VA = "0x270C698")]
	private Vector3 KGOHPMEFELA(Vector3 GGAPINMPMEN, float EGHHKPCJNCH, Vector3 PFAPJJODMCM)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6002506")]
	[Address(RVA = "0x270CAF0", Offset = "0x270CAF0", VA = "0x270CAF0")]
	protected void DHCBOJOEBAL(float EAHHJDBOCLH)
	{
	}

	[Token(Token = "0x6002507")]
	[Address(RVA = "0x270D2EC", Offset = "0x270D2EC", VA = "0x270D2EC")]
	public string _003C_003EiFixBaseProxy_GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002508")]
	[Address(RVA = "0x270D2F4", Offset = "0x270D2F4", VA = "0x270D2F4")]
	public new void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	[Token(Token = "0x6002509")]
	[Address(RVA = "0x270D2FC", Offset = "0x270D2FC", VA = "0x270D2FC")]
	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	[Token(Token = "0x600250A")]
	[Address(RVA = "0x270D304", Offset = "0x270D304", VA = "0x270D304")]
	public new void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}
}
