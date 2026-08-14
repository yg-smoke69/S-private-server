using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003E30")]
public class AkRoomPortal : AkTriggerHandler
{
	[Token(Token = "0x2003E31")]
	public enum State
	{
		[Token(Token = "0x401A55B")]
		Closed,
		[Token(Token = "0x401A55C")]
		Open
	}

	[Token(Token = "0x401A553")]
	public const int MAX_ROOMS_PER_PORTAL = 2;

	[Token(Token = "0x401A554")]
	[FieldOffset(Offset = "0x18")]
	public State initialState;

	[Token(Token = "0x401A555")]
	[FieldOffset(Offset = "0x1C")]
	private AkVector extent;

	[Token(Token = "0x401A556")]
	[FieldOffset(Offset = "0x20")]
	private AkTransform portalTransform;

	[Token(Token = "0x401A557")]
	[FieldOffset(Offset = "0x24")]
	private bool active;

	[Token(Token = "0x401A558")]
	[FieldOffset(Offset = "0x28")]
	public List<int> closePortalTriggerList;

	[Token(Token = "0x401A559")]
	[FieldOffset(Offset = "0x2C")]
	private AkRoom[] rooms;

	[Token(Token = "0x17001B8C")]
	public bool portalActive
	{
		[Token(Token = "0x601947B")]
		[Address(RVA = "0x36C805C", Offset = "0x36C805C", VA = "0x36C805C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601947C")]
		[Address(RVA = "0x36C8064", Offset = "0x36C8064", VA = "0x36C8064")]
		set
		{
		}
	}

	[Token(Token = "0x17001B8D")]
	private ulong frontRoomID
	{
		[Token(Token = "0x601947D")]
		[Address(RVA = "0x36C8220", Offset = "0x36C8220", VA = "0x36C8220")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x17001B8E")]
	private ulong backRoomID
	{
		[Token(Token = "0x601947E")]
		[Address(RVA = "0x36C83E0", Offset = "0x36C83E0", VA = "0x36C83E0")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x17001B8F")]
	public AkRoom frontRoom
	{
		[Token(Token = "0x6019483")]
		[Address(RVA = "0x36C82F0", Offset = "0x36C82F0", VA = "0x36C82F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B90")]
	public AkRoom backRoom
	{
		[Token(Token = "0x6019484")]
		[Address(RVA = "0x36C84B0", Offset = "0x36C84B0", VA = "0x36C84B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B91")]
	public bool IsValid
	{
		[Token(Token = "0x6019486")]
		[Address(RVA = "0x36C8958", Offset = "0x36C8958", VA = "0x36C8958")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x601947A")]
	[Address(RVA = "0x36C7F80", Offset = "0x36C7F80", VA = "0x36C7F80")]
	public AkRoomPortal()
	{
	}

	[Token(Token = "0x601947F")]
	[Address(RVA = "0x36C84F0", Offset = "0x36C84F0", VA = "0x36C84F0")]
	public void SetRoom(int in_roomIndex, AkRoom in_room)
	{
	}

	[Token(Token = "0x6019480")]
	[Address(RVA = "0x36C8628", Offset = "0x36C8628", VA = "0x36C8628")]
	public void SetFrontRoom(AkRoom room)
	{
	}

	[Token(Token = "0x6019481")]
	[Address(RVA = "0x36C8634", Offset = "0x36C8634", VA = "0x36C8634")]
	public void SetBackRoom(AkRoom room)
	{
	}

	[Token(Token = "0x6019482")]
	[Address(RVA = "0x36C8640", Offset = "0x36C8640", VA = "0x36C8640")]
	public AkRoom GetRoom(int index)
	{
		return null;
	}

	[Token(Token = "0x6019485")]
	[Address(RVA = "0x36C8688", Offset = "0x36C8688", VA = "0x36C8688")]
	public void UpdateSoundEngineRoomIDs()
	{
	}

	[Token(Token = "0x6019487")]
	[Address(RVA = "0x36C8850", Offset = "0x36C8850", VA = "0x36C8850")]
	public ulong GetID()
	{
		return default(ulong);
	}

	[Token(Token = "0x6019488")]
	[Address(RVA = "0x36C898C", Offset = "0x36C898C", VA = "0x36C898C", Slot = "5")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6019489")]
	[Address(RVA = "0x36C9308", Offset = "0x36C9308", VA = "0x36C9308", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x601948A")]
	[Address(RVA = "0x36C93A8", Offset = "0x36C93A8", VA = "0x36C93A8", Slot = "4")]
	public override void HandleEvent(GameObject in_gameObject)
	{
	}

	[Token(Token = "0x601948B")]
	[Address(RVA = "0x36C9300", Offset = "0x36C9300", VA = "0x36C9300")]
	public void ClosePortal(GameObject in_gameObject)
	{
	}

	[Token(Token = "0x601948C")]
	[Address(RVA = "0x36C93C0", Offset = "0x36C93C0", VA = "0x36C93C0", Slot = "7")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x601948D")]
	[Address(RVA = "0x36C8330", Offset = "0x36C8330", VA = "0x36C8330")]
	private bool IsRoomActive(AkRoom in_room)
	{
		return default(bool);
	}

	[Token(Token = "0x601948E")]
	[Address(RVA = "0x36C93B0", Offset = "0x36C93B0", VA = "0x36C93B0")]
	public void Open()
	{
	}

	[Token(Token = "0x601948F")]
	[Address(RVA = "0x36C93B8", Offset = "0x36C93B8", VA = "0x36C93B8")]
	public void Close()
	{
	}

	[Token(Token = "0x6019490")]
	[Address(RVA = "0x36C9700", Offset = "0x36C9700", VA = "0x36C9700")]
	public void FindOverlappingRooms(AkRoom.PriorityList[] roomList)
	{
	}

	[Token(Token = "0x6019491")]
	[Address(RVA = "0x36C9A4C", Offset = "0x36C9A4C", VA = "0x36C9A4C")]
	private void FillRoomList(Vector3 center, Vector3 halfExtents, AkRoom.PriorityList list)
	{
	}

	[Token(Token = "0x6019492")]
	[Address(RVA = "0x36C8F98", Offset = "0x36C8F98", VA = "0x36C8F98")]
	public void UpdateOverlappingRooms()
	{
	}
}
