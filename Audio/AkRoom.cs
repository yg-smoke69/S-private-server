using System.Collections.Generic;
using System.Runtime.InteropServices;
using AK.Wwise;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003E2D")]
public class AkRoom : AkTriggerHandler
{
	[Token(Token = "0x2003E2E")]
	public class PriorityList
	{
		[Token(Token = "0x2003E2F")]
		private class CompareByPriority : _Attribute
		{
			[Token(Token = "0x6019478")]
			[Address(RVA = "0x36C7860", Offset = "0x36C7860", VA = "0x36C7860")]
			public CompareByPriority()
			{
			}

			[Token(Token = "0x6019479")]
			[Address(RVA = "0x36C7868", Offset = "0x36C7868", VA = "0x36C7868", Slot = "5")]
			public virtual int Compare(AkRoom a, AkRoom b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x401A551")]
		[FieldOffset(Offset = "0x0")]
		private static readonly CompareByPriority s_compareByPriority;

		[Token(Token = "0x401A552")]
		[FieldOffset(Offset = "0x8")]
		public List<AkRoom> rooms;

		[Token(Token = "0x6019470")]
		[Address(RVA = "0x36C7354", Offset = "0x36C7354", VA = "0x36C7354")]
		public PriorityList()
		{
		}

		[Token(Token = "0x6019471")]
		[Address(RVA = "0x36C73E0", Offset = "0x36C73E0", VA = "0x36C73E0")]
		public ulong GetHighestPriorityRoomID()
		{
			return default(ulong);
		}

		[Token(Token = "0x6019472")]
		[Address(RVA = "0x36C74DC", Offset = "0x36C74DC", VA = "0x36C74DC")]
		public AkRoom GetHighestPriorityRoom()
		{
			return null;
		}

		[Token(Token = "0x6019473")]
		[Address(RVA = "0x36C7594", Offset = "0x36C7594", VA = "0x36C7594")]
		public void Add(AkRoom room)
		{
		}

		[Token(Token = "0x6019474")]
		[Address(RVA = "0x36C7740", Offset = "0x36C7740", VA = "0x36C7740")]
		public void Remove(AkRoom room)
		{
		}

		[Token(Token = "0x6019475")]
		[Address(RVA = "0x36C77C0", Offset = "0x36C77C0", VA = "0x36C77C0")]
		public bool Contains(AkRoom room)
		{
			return default(bool);
		}

		[Token(Token = "0x6019476")]
		[Address(RVA = "0x36C7630", Offset = "0x36C7630", VA = "0x36C7630")]
		public int BinarySearch(AkRoom room)
		{
			return default(int);
		}
	}

	[Token(Token = "0x401A549")]
	[FieldOffset(Offset = "0x0")]
	public static ulong INVALID_ROOM_ID;

	[Token(Token = "0x401A54A")]
	[FieldOffset(Offset = "0x8")]
	private static int RoomCount;

	[Token(Token = "0x401A54B")]
	[FieldOffset(Offset = "0x18")]
	public int priority;

	[Token(Token = "0x401A54C")]
	[FieldOffset(Offset = "0x1C")]
	public AuxBus reverbAuxBus;

	[Token(Token = "0x401A54D")]
	[FieldOffset(Offset = "0x20")]
	public float reverbLevel;

	[Token(Token = "0x401A54E")]
	[FieldOffset(Offset = "0x24")]
	public float wallOcclusion;

	[Token(Token = "0x401A54F")]
	[FieldOffset(Offset = "0x28")]
	public Event roomToneEvent;

	[Token(Token = "0x401A550")]
	[FieldOffset(Offset = "0x2C")]
	public float roomToneAuxSend;

	[Token(Token = "0x17001B8B")]
	public static bool IsSpatialAudioEnabled
	{
		[Token(Token = "0x6019468")]
		[Address(RVA = "0x36C5E64", Offset = "0x36C5E64", VA = "0x36C5E64")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6019467")]
	[Address(RVA = "0x36C5D8C", Offset = "0x36C5D8C", VA = "0x36C5D8C")]
	public AkRoom()
	{
	}

	[Token(Token = "0x6019469")]
	[Address(RVA = "0x36C5F80", Offset = "0x36C5F80", VA = "0x36C5F80")]
	public ulong GetID()
	{
		return default(ulong);
	}

	[Token(Token = "0x601946A")]
	[Address(RVA = "0x36C6010", Offset = "0x36C6010", VA = "0x36C6010")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x601946B")]
	[Address(RVA = "0x36C6EBC", Offset = "0x36C6EBC", VA = "0x36C6EBC", Slot = "4")]
	public override void HandleEvent(GameObject in_gameObject)
	{
	}

	[Token(Token = "0x601946C")]
	[Address(RVA = "0x36C6EF8", Offset = "0x36C6EF8", VA = "0x36C6EF8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x601946D")]
	[Address(RVA = "0x36C7098", Offset = "0x36C7098", VA = "0x36C7098")]
	private void OnTriggerEnter(Collider in_other)
	{
	}

	[Token(Token = "0x601946E")]
	[Address(RVA = "0x36C71C0", Offset = "0x36C71C0", VA = "0x36C71C0")]
	private void OnTriggerExit(Collider in_other)
	{
	}
}
