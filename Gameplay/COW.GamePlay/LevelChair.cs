using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20005EF")]
public class LevelChair : BaseLevelObject
{
	[Token(Token = "0x20005F0")]
	public enum HBEKCGONJNL
	{
		[Token(Token = "0x40044CC")]
		CREATE,
		[Token(Token = "0x40044CD")]
		GET_ON,
		[Token(Token = "0x40044CE")]
		GET_OFF
	}

	[Token(Token = "0x40044C4")]
	[FieldOffset(Offset = "0x74")]
	public Transform OnSeatPosition;

	[Token(Token = "0x40044C5")]
	[FieldOffset(Offset = "0x78")]
	public Transform JumpOffPosition;

	[Token(Token = "0x40044C6")]
	[FieldOffset(Offset = "0x7C")]
	public AnimRef SittingAnimation;

	[Token(Token = "0x40044C7")]
	[FieldOffset(Offset = "0x80")]
	public AnimRef SittingAnimationFemale;

	[Token(Token = "0x40044C8")]
	[FieldOffset(Offset = "0x84")]
	public uint ChairModelID;

	[Token(Token = "0x40044C9")]
	[FieldOffset(Offset = "0x88")]
	protected IHAAMHPPLMG MIGDFGMDINF;

	[Token(Token = "0x40044CA")]
	[FieldOffset(Offset = "0xA0")]
	protected IHAAMHPPLMG JNONENGNPHG;

	[Token(Token = "0x6002430")]
	[Address(RVA = "0x23819C0", Offset = "0x23819C0", VA = "0x23819C0")]
	public LevelChair()
	{
	}

	[Token(Token = "0x6002431")]
	[Address(RVA = "0x2381A84", Offset = "0x2381A84", VA = "0x2381A84", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002432")]
	[Address(RVA = "0x2381B28", Offset = "0x2381B28", VA = "0x2381B28", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6002433")]
	[Address(RVA = "0x2381D4C", Offset = "0x2381D4C", VA = "0x2381D4C")]
	public bool HasPlayerOnSeat()
	{
		return default(bool);
	}

	[Token(Token = "0x6002434")]
	[Address(RVA = "0x2381E98", Offset = "0x2381E98", VA = "0x2381E98")]
	public bool CanGetOn()
	{
		return default(bool);
	}

	[Token(Token = "0x6002435")]
	[Address(RVA = "0x2381EFC", Offset = "0x2381EFC", VA = "0x2381EFC")]
	public Vector3 GetOnSeatPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6002436")]
	[Address(RVA = "0x2382018", Offset = "0x2382018", VA = "0x2382018")]
	public Vector3 GetOnSeatForward()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6002437")]
	[Address(RVA = "0x2382134", Offset = "0x2382134", VA = "0x2382134")]
	public Vector3 GetOffPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6002438")]
	[Address(RVA = "0x23822D4", Offset = "0x23822D4", VA = "0x23822D4", Slot = "30")]
	public override void DoAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002439")]
	[Address(RVA = "0x2383078", Offset = "0x2383078", VA = "0x2383078", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x600243A")]
	[Address(RVA = "0x23826E8", Offset = "0x23826E8", VA = "0x23826E8")]
	private bool AJAMMEKCIEO(Player PJOIFFLCDPM)
	{
		return default(bool);
	}

	[Token(Token = "0x600243B")]
	[Address(RVA = "0x23832B0", Offset = "0x23832B0", VA = "0x23832B0")]
	internal void FBBGEDLKDLL(Player KAEHJEGFKBL)
	{
	}

	[Token(Token = "0x600243C")]
	[Address(RVA = "0x2382874", Offset = "0x2382874", VA = "0x2382874")]
	private void NGBFONHHHMK(Player KAEHJEGFKBL, bool PGNHJFIGGML)
	{
	}

	[Token(Token = "0x600243D")]
	[Address(RVA = "0x23835E8", Offset = "0x23835E8", VA = "0x23835E8")]
	internal void CPILPBNFAFB(Player KAEHJEGFKBL, bool KEJJJHEBNLF)
	{
	}

	[Token(Token = "0x600243E")]
	[Address(RVA = "0x2383320", Offset = "0x2383320", VA = "0x2383320")]
	private void POANHJEDPBE(Player KAEHJEGFKBL, bool PGNHJFIGGML)
	{
	}

	[Token(Token = "0x600243F")]
	[Address(RVA = "0x238373C", Offset = "0x238373C", VA = "0x238373C")]
	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x6002440")]
	[Address(RVA = "0x2383744", Offset = "0x2383744", VA = "0x2383744")]
	public void _003C_003EiFixBaseProxy_DoAction(object[] P0)
	{
	}

	[Token(Token = "0x6002441")]
	[Address(RVA = "0x238374C", Offset = "0x238374C", VA = "0x238374C")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}
}
