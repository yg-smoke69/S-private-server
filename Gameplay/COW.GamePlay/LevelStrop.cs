using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20006A3")]
public class LevelStrop : BaseLevelObject
{
	[Token(Token = "0x20006A4")]
	public enum INAJCEKCNCB
	{
		[Token(Token = "0x40048EB")]
		GET_ON,
		[Token(Token = "0x40048EC")]
		GET_OFF,
		[Token(Token = "0x40048ED")]
		CREATE,
		[Token(Token = "0x40048EE")]
		DELETE
	}

	[Token(Token = "0x40048E3")]
	[FieldOffset(Offset = "0x74")]
	public Transform StartPoint;

	[Token(Token = "0x40048E4")]
	[FieldOffset(Offset = "0x78")]
	public Transform EndPoint;

	[Token(Token = "0x40048E5")]
	[FieldOffset(Offset = "0x7C")]
	public LineRenderer StropLine;

	[Token(Token = "0x40048E6")]
	[FieldOffset(Offset = "0x80")]
	private Collider ABLAOAPPBGF;

	[Token(Token = "0x40048E7")]
	[FieldOffset(Offset = "0x84")]
	private LevelStropShelf BAJIKPFOJEF;

	[Token(Token = "0x40048E8")]
	[FieldOffset(Offset = "0x88")]
	private LevelStropShelf GCCJNOJAFMC;

	[Token(Token = "0x40048E9")]
	[FieldOffset(Offset = "0x8C")]
	private float GMEKCGLIJIM;

	[Token(Token = "0x17000342")]
	public Vector3 BOGOIAMJFDN
	{
		[Token(Token = "0x6002A9E")]
		[Address(RVA = "0x20D24CC", Offset = "0x20D24CC", VA = "0x20D24CC")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000343")]
	public Vector3 BCJFHJOHMEP
	{
		[Token(Token = "0x6002A9F")]
		[Address(RVA = "0x20D2550", Offset = "0x20D2550", VA = "0x20D2550")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000344")]
	private bool LLJPECKFDHB
	{
		[Token(Token = "0x6002AA3")]
		[Address(RVA = "0x20D2864", Offset = "0x20D2864", VA = "0x20D2864")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6002A9D")]
	[Address(RVA = "0x20D24B8", Offset = "0x20D24B8", VA = "0x20D24B8")]
	public LevelStrop()
	{
	}

	[Token(Token = "0x6002AA0")]
	[Address(RVA = "0x20D25D4", Offset = "0x20D25D4", VA = "0x20D25D4", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002AA1")]
	[Address(RVA = "0x20D2678", Offset = "0x20D2678", VA = "0x20D2678", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6002AA2")]
	[Address(RVA = "0x20D280C", Offset = "0x20D280C", VA = "0x20D280C", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002AA4")]
	[Address(RVA = "0x20D2988", Offset = "0x20D2988", VA = "0x20D2988", Slot = "40")]
	protected virtual void PDGCBLMCIND(bool JGLJDJFHPBO, bool DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002AA5")]
	[Address(RVA = "0x20D29F8", Offset = "0x20D29F8", VA = "0x20D29F8", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6002AA6")]
	[Address(RVA = "0x20D2D18", Offset = "0x20D2D18", VA = "0x20D2D18")]
	public void UpdateLine()
	{
	}

	[Token(Token = "0x6002AA7")]
	[Address(RVA = "0x20D2EB0", Offset = "0x20D2EB0", VA = "0x20D2EB0")]
	public Vector3 GetMoveDir()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6002AA8")]
	[Address(RVA = "0x20D3024", Offset = "0x20D3024", VA = "0x20D3024")]
	public LevelStropShelf GetStartShelf()
	{
		return null;
	}

	[Token(Token = "0x6002AA9")]
	[Address(RVA = "0x20D3284", Offset = "0x20D3284", VA = "0x20D3284")]
	public LevelStropShelf GetEndShelf()
	{
		return null;
	}

	[Token(Token = "0x6002AAA")]
	[Address(RVA = "0x20D34E4", Offset = "0x20D34E4", VA = "0x20D34E4")]
	public void SetLineVisible(bool JOGHOHLEJFL)
	{
	}

	[Token(Token = "0x6002AAB")]
	[Address(RVA = "0x20D361C", Offset = "0x20D361C", VA = "0x20D361C")]
	public float GetLength()
	{
		return default(float);
	}

	[Token(Token = "0x6002AAC")]
	[Address(RVA = "0x20D3794", Offset = "0x20D3794", VA = "0x20D3794", Slot = "30")]
	public override void DoAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002AAD")]
	[Address(RVA = "0x20D3DAC", Offset = "0x20D3DAC", VA = "0x20D3DAC", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002AAE")]
	[Address(RVA = "0x20D47F0", Offset = "0x20D47F0", VA = "0x20D47F0")]
	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6002AAF")]
	[Address(RVA = "0x20D47F8", Offset = "0x20D47F8", VA = "0x20D47F8")]
	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002AB0")]
	[Address(RVA = "0x20D4800", Offset = "0x20D4800", VA = "0x20D4800")]
	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x6002AB1")]
	[Address(RVA = "0x20D4808", Offset = "0x20D4808", VA = "0x20D4808")]
	public void _003C_003EiFixBaseProxy_DoAction(object[] P0)
	{
	}

	[Token(Token = "0x6002AB2")]
	[Address(RVA = "0x20D4810", Offset = "0x20D4810", VA = "0x20D4810")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}
}
