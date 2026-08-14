using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AAA")]
public class MeteorEffectController : MonoBehaviour
{
	[Token(Token = "0x2000AAB")]
	public struct MeteorShowerTime
	{
		[Token(Token = "0x4005D54")]
		[FieldOffset(Offset = "0x0")]
		public DateTime startTime;

		[Token(Token = "0x4005D55")]
		[FieldOffset(Offset = "0x10")]
		public DateTime endTime;

		[Token(Token = "0x4005D56")]
		[FieldOffset(Offset = "0x20")]
		public bool isRandom;
	}

	[Token(Token = "0x4005D48")]
	[FieldOffset(Offset = "0xC")]
	public GameObject meteorPrefab;

	[Token(Token = "0x4005D49")]
	[FieldOffset(Offset = "0x10")]
	public int meteorStartHour;

	[Token(Token = "0x4005D4A")]
	[FieldOffset(Offset = "0x14")]
	public int meteorEndHour;

	[Token(Token = "0x4005D4B")]
	[FieldOffset(Offset = "0x18")]
	public int[] timeSegments;

	[Token(Token = "0x4005D4C")]
	[FieldOffset(Offset = "0x1C")]
	private bool isDuringMeteorShower;

	[Token(Token = "0x4005D4D")]
	[FieldOffset(Offset = "0x20")]
	private int generalMeteorDuration;

	[Token(Token = "0x4005D4E")]
	[FieldOffset(Offset = "0x24")]
	private GameObject instance;

	[Token(Token = "0x4005D4F")]
	[FieldOffset(Offset = "0x28")]
	private ParticleSystem[] particles;

	[Token(Token = "0x4005D50")]
	[FieldOffset(Offset = "0x2C")]
	public string meteorSpecificTime;

	[Token(Token = "0x4005D51")]
	[FieldOffset(Offset = "0x30")]
	private int weatherNightEnd;

	[Token(Token = "0x4005D52")]
	[FieldOffset(Offset = "0x34")]
	private int weatherNightStart;

	[Token(Token = "0x4005D53")]
	[FieldOffset(Offset = "0x38")]
	private Queue<MeteorShowerTime> _003CpendingShowTime_003Ek__BackingField;

	[Token(Token = "0x1700064C")]
	public Queue<MeteorShowerTime> pendingShowTime
	{
		[Token(Token = "0x600519F")]
		[Address(RVA = "0x1C6CD5C", Offset = "0x1C6CD5C", VA = "0x1C6CD5C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60051A0")]
		[Address(RVA = "0x1C6CD64", Offset = "0x1C6CD64", VA = "0x1C6CD64")]
		private set
		{
		}
	}

	[Token(Token = "0x600519E")]
	[Address(RVA = "0x1C6CD44", Offset = "0x1C6CD44", VA = "0x1C6CD44")]
	public MeteorEffectController()
	{
	}

	[Token(Token = "0x60051A1")]
	[Address(RVA = "0x1C6CD6C", Offset = "0x1C6CD6C", VA = "0x1C6CD6C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60051A2")]
	[Address(RVA = "0x1C6D008", Offset = "0x1C6D008", VA = "0x1C6D008")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60051A3")]
	[Address(RVA = "0x1C6DA3C", Offset = "0x1C6DA3C", VA = "0x1C6DA3C")]
	private void TickMeteorShower()
	{
	}

	[Token(Token = "0x60051A4")]
	[Address(RVA = "0x1C6E0AC", Offset = "0x1C6E0AC", VA = "0x1C6E0AC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60051A5")]
	[Address(RVA = "0x1C6E218", Offset = "0x1C6E218", VA = "0x1C6E218")]
	private DateTime GetDayOfTheNight(DateTime time)
	{
		return default(DateTime);
	}

	[Token(Token = "0x60051A6")]
	[Address(RVA = "0x1C6DA94", Offset = "0x1C6DA94", VA = "0x1C6DA94")]
	private bool IsInMeteorShowerTime()
	{
		return default(bool);
	}

	[Token(Token = "0x60051A7")]
	[Address(RVA = "0x1C6DDEC", Offset = "0x1C6DDEC", VA = "0x1C6DDEC")]
	private void StartMeteorShower()
	{
	}

	[Token(Token = "0x60051A8")]
	[Address(RVA = "0x1C6E028", Offset = "0x1C6E028", VA = "0x1C6E028")]
	private void StopMeteorShower()
	{
	}

	[Token(Token = "0x60051A9")]
	[Address(RVA = "0x1C6E2CC", Offset = "0x1C6E2CC", VA = "0x1C6E2CC")]
	private void OnMeteorSpecificTimeUpdate(object[] param)
	{
	}

	[Token(Token = "0x60051AA")]
	[Address(RVA = "0x1C6D0C0", Offset = "0x1C6D0C0", VA = "0x1C6D0C0")]
	private void UpdatePendingShowData()
	{
	}
}
