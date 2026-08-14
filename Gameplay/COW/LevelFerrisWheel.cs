using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000620")]
public class LevelFerrisWheel : BaseLevelObject
{
	[Token(Token = "0x2000621")]
	public enum ELevelFerrisWheelAction
	{
		[Token(Token = "0x4004610")]
		SYNC_ANGLE,
		[Token(Token = "0x4004611")]
		GET_ON,
		[Token(Token = "0x4004612")]
		GET_OFF
	}

	[Token(Token = "0x2000622")]
	private class ShadowState : ShadowStateBase
	{
		[Token(Token = "0x4004613")]
		[FieldOffset(Offset = "0x10")]
		public float CurAngle;

		[Token(Token = "0x4004614")]
		[FieldOffset(Offset = "0x14")]
		public float NextAngle;

		[Token(Token = "0x60025F0")]
		[Address(RVA = "0xEBD5B8", Offset = "0xEBD5B8", VA = "0xEBD5B8")]
		public ShadowState()
		{
		}
	}

	[Token(Token = "0x4004608")]
	[FieldOffset(Offset = "0x74")]
	public FerrisWheelSeatGroup[] SeatGroup;

	[Token(Token = "0x4004609")]
	[FieldOffset(Offset = "0x78")]
	public Transform RotationCenter;

	[Token(Token = "0x400460A")]
	[FieldOffset(Offset = "0x7C")]
	public Transform GetOffPos;

	[Token(Token = "0x400460B")]
	[FieldOffset(Offset = "0x80")]
	public float Radius;

	[Token(Token = "0x400460C")]
	[FieldOffset(Offset = "0x84")]
	public float RotaSpeed;

	[Token(Token = "0x400460D")]
	[FieldOffset(Offset = "0x88")]
	private ShadowState m_ShadowState;

	[Token(Token = "0x400460E")]
	[FieldOffset(Offset = "0x8C")]
	protected uint m_LastValidTickCount;

	[Token(Token = "0x60025E5")]
	[Address(RVA = "0xEBD528", Offset = "0xEBD528", VA = "0xEBD528")]
	public LevelFerrisWheel()
	{
	}

	[Token(Token = "0x60025E6")]
	[Address(RVA = "0xEBD5C0", Offset = "0xEBD5C0", VA = "0xEBD5C0", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x60025E7")]
	[Address(RVA = "0xEBD664", Offset = "0xEBD664", VA = "0xEBD664")]
	private void Awake()
	{
	}

	[Token(Token = "0x60025E8")]
	[Address(RVA = "0xEBD6F0", Offset = "0xEBD6F0", VA = "0xEBD6F0", Slot = "17")]
	public override void OnFixedUpdate(float gameTime, float deltaTime)
	{
	}

	[Token(Token = "0x60025E9")]
	[Address(RVA = "0xEBD8E8", Offset = "0xEBD8E8", VA = "0xEBD8E8")]
	private void UpdateRotationAngle(float newVal, uint tickCount)
	{
	}

	[Token(Token = "0x60025EA")]
	[Address(RVA = "0xEBD9FC", Offset = "0xEBD9FC", VA = "0xEBD9FC")]
	public void OnPlayerGetOn(IHAAMHPPLMG pID, byte seatGroup, byte seatIndex)
	{
	}

	[Token(Token = "0x60025EB")]
	[Address(RVA = "0xEBDEB4", Offset = "0xEBDEB4", VA = "0xEBDEB4")]
	public void OnPlayerGetOff(byte seatGroup, byte seatIndex)
	{
	}

	[Token(Token = "0x60025EC")]
	[Address(RVA = "0xEBDD60", Offset = "0xEBDD60", VA = "0xEBDD60")]
	private FerrisWheelSeat GetPlayerMountSeat(byte groupID, byte seatInx)
	{
		return null;
	}

	[Token(Token = "0x60025ED")]
	[Address(RVA = "0xEBE0C8", Offset = "0xEBE0C8", VA = "0xEBE0C8", Slot = "31")]
	public override void SyncAction(object[] param)
	{
	}

	[Token(Token = "0x60025EE")]
	[Address(RVA = "0xEBE5A8", Offset = "0xEBE5A8", VA = "0xEBE5A8")]
	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}

	[Token(Token = "0x60025EF")]
	[Address(RVA = "0xEBE5B0", Offset = "0xEBE5B0", VA = "0xEBE5B0")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}
}
