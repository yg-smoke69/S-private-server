using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;

namespace GCommon;

[Token(Token = "0x200406C")]
public class NetworkDetection : MonoBehaviour
{
	[Token(Token = "0x200406D")]
	public delegate void MultiTaskComplete(List<NetDetectionResult> results, object extra_data);

	[Token(Token = "0x200406E")]
	private class PingInfo
	{
		[Token(Token = "0x401B1AE")]
		[FieldOffset(Offset = "0x8")]
		public float PingTime;

		[Token(Token = "0x401B1AF")]
		[FieldOffset(Offset = "0xC")]
		public bool IsTimeOut;

		[Token(Token = "0x601A37A")]
		[Address(RVA = "0x2971AA4", Offset = "0x2971AA4", VA = "0x2971AA4")]
		public PingInfo()
		{
		}
	}

	[Token(Token = "0x200406F")]
	private class TaskInfo
	{
		[Token(Token = "0x401B1B0")]
		[FieldOffset(Offset = "0x8")]
		public List<string> TargetIPList;

		[Token(Token = "0x401B1B1")]
		[FieldOffset(Offset = "0xC")]
		public List<NetDetectionResult> Results;

		[Token(Token = "0x401B1B2")]
		[FieldOffset(Offset = "0x10")]
		public int IPCount;

		[Token(Token = "0x401B1B3")]
		[FieldOffset(Offset = "0x14")]
		public ETaskType TaskType;

		[Token(Token = "0x401B1B4")]
		[FieldOffset(Offset = "0x18")]
		public ETaskFunction TaskFunc;

		[Token(Token = "0x401B1B5")]
		[FieldOffset(Offset = "0x1C")]
		public uint ThreadCount;

		[Token(Token = "0x401B1B6")]
		[FieldOffset(Offset = "0x20")]
		public object ExtraData;

		[Token(Token = "0x401B1B7")]
		[FieldOffset(Offset = "0x24")]
		private MultiTaskComplete call_back;

		[Token(Token = "0x601A37B")]
		[Address(RVA = "0x296FD2C", Offset = "0x296FD2C", VA = "0x296FD2C")]
		public TaskInfo(string[] target_ip_list, ETaskType type, ETaskFunction func, MultiTaskComplete complete_callback, uint thread_count = 1u, [Optional] object extra_data)
		{
		}

		[Token(Token = "0x601A37C")]
		[Address(RVA = "0x29703D4", Offset = "0x29703D4", VA = "0x29703D4")]
		public string GetNextPingAddress()
		{
			return null;
		}

		[Token(Token = "0x601A37D")]
		[Address(RVA = "0x29713A4", Offset = "0x29713A4", VA = "0x29713A4")]
		public void InvokeComplete()
		{
		}
	}

	[Token(Token = "0x2004070")]
	private sealed class _003CMultiPing_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x401B1B8")]
		[FieldOffset(Offset = "0x8")]
		internal string address;

		[Token(Token = "0x401B1B9")]
		[FieldOffset(Offset = "0xC")]
		internal Ping _003Cping_003E__1;

		[Token(Token = "0x401B1BA")]
		[FieldOffset(Offset = "0x10")]
		internal float _003Cused_time_003E__1;

		[Token(Token = "0x401B1BB")]
		[FieldOffset(Offset = "0x14")]
		internal List<PingInfo> infos;

		[Token(Token = "0x401B1BC")]
		[FieldOffset(Offset = "0x18")]
		internal TaskInfo task_info;

		[Token(Token = "0x401B1BD")]
		[FieldOffset(Offset = "0x1C")]
		internal NetworkDetection _0024this;

		[Token(Token = "0x401B1BE")]
		[FieldOffset(Offset = "0x20")]
		internal object _0024current;

		[Token(Token = "0x401B1BF")]
		[FieldOffset(Offset = "0x24")]
		internal bool _0024disposing;

		[Token(Token = "0x401B1C0")]
		[FieldOffset(Offset = "0x28")]
		internal int _0024PC;

		[Token(Token = "0x17001CBD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x601A380")]
			[Address(RVA = "0x2971AAC", Offset = "0x2971AAC", VA = "0x2971AAC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001CBE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x601A381")]
			[Address(RVA = "0x2971AB4", Offset = "0x2971AB4", VA = "0x2971AB4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x601A37E")]
		[Address(RVA = "0x296FFB8", Offset = "0x296FFB8", VA = "0x296FFB8")]
		public _003CMultiPing_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x601A37F")]
		[Address(RVA = "0x29716FC", Offset = "0x29716FC", VA = "0x29716FC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601A382")]
		[Address(RVA = "0x2971ABC", Offset = "0x2971ABC", VA = "0x2971ABC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601A383")]
		[Address(RVA = "0x2971AD0", Offset = "0x2971AD0", VA = "0x2971AD0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2004071")]
	private sealed class _003COnTraceRouteCompleted_003Ec__AnonStorey2
	{
		[Token(Token = "0x401B1C1")]
		[FieldOffset(Offset = "0x8")]
		internal TracerouteResult result;

		[Token(Token = "0x601A384")]
		[Address(RVA = "0x29711AC", Offset = "0x29711AC", VA = "0x29711AC")]
		public _003COnTraceRouteCompleted_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x601A385")]
		[Address(RVA = "0x2971B58", Offset = "0x2971B58", VA = "0x2971B58")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2004072")]
	private sealed class _003CTestCDN_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x401B1C2")]
		[FieldOffset(Offset = "0x8")]
		internal string url;

		[Token(Token = "0x401B1C3")]
		[FieldOffset(Offset = "0xC")]
		internal UnityWebRequest _003CwebRequest_003E__0;

		[Token(Token = "0x401B1C4")]
		[FieldOffset(Offset = "0x10")]
		internal CDNResult _003Cresult_003E__0;

		[Token(Token = "0x401B1C5")]
		[FieldOffset(Offset = "0x14")]
		internal NetworkDetection _0024this;

		[Token(Token = "0x401B1C6")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x401B1C7")]
		[FieldOffset(Offset = "0x1C")]
		internal bool _0024disposing;

		[Token(Token = "0x401B1C8")]
		[FieldOffset(Offset = "0x20")]
		internal int _0024PC;

		[Token(Token = "0x17001CBF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x601A388")]
			[Address(RVA = "0x2971E80", Offset = "0x2971E80", VA = "0x2971E80", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001CC0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x601A389")]
			[Address(RVA = "0x2971E88", Offset = "0x2971E88", VA = "0x2971E88", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x601A386")]
		[Address(RVA = "0x297139C", Offset = "0x297139C", VA = "0x297139C")]
		public _003CTestCDN_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x601A387")]
		[Address(RVA = "0x2971B90", Offset = "0x2971B90", VA = "0x2971B90", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601A38A")]
		[Address(RVA = "0x2971E90", Offset = "0x2971E90", VA = "0x2971E90", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601A38B")]
		[Address(RVA = "0x2971EA4", Offset = "0x2971EA4", VA = "0x2971EA4", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x401B1A7")]
	private const float PING_TIMEOUT = 3f;

	[Token(Token = "0x401B1A8")]
	private const int PING_COUNT = 5;

	[Token(Token = "0x401B1A9")]
	private const string ERROR_CODE_START = "ErrorCode:";

	[Token(Token = "0x401B1AA")]
	[FieldOffset(Offset = "0x0")]
	private static NetworkDetection m_Instance;

	[Token(Token = "0x401B1AB")]
	[FieldOffset(Offset = "0xC")]
	private float m_StartTime;

	[Token(Token = "0x401B1AC")]
	[FieldOffset(Offset = "0x10")]
	private LinkedList<TaskInfo> m_PendingTaskList;

	[Token(Token = "0x401B1AD")]
	[FieldOffset(Offset = "0x14")]
	private TaskInfo m_RunningTask;

	[Token(Token = "0x17001CBC")]
	public static NetworkDetection Instance
	{
		[Token(Token = "0x601A367")]
		[Address(RVA = "0x296F758", Offset = "0x296F758", VA = "0x296F758")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601A366")]
	[Address(RVA = "0x296F6CC", Offset = "0x296F6CC", VA = "0x296F6CC")]
	public NetworkDetection()
	{
	}

	[Token(Token = "0x601A368")]
	[Address(RVA = "0x296F910", Offset = "0x296F910", VA = "0x296F910")]
	private void Init()
	{
	}

	[Token(Token = "0x601A369")]
	[Address(RVA = "0x296F994", Offset = "0x296F994", VA = "0x296F994")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x601A36A")]
	[Address(RVA = "0x296FA18", Offset = "0x296FA18", VA = "0x296FA18")]
	public void Clear(uint include_task = uint.MaxValue)
	{
	}

	[Token(Token = "0x601A36B")]
	[Address(RVA = "0x296FC60", Offset = "0x296FC60", VA = "0x296FC60")]
	public void Ping(ETaskType type, string[] address_list, MultiTaskComplete call_back, [Optional] object extra_data)
	{
	}

	[Token(Token = "0x601A36C")]
	[Address(RVA = "0x296FEE8", Offset = "0x296FEE8", VA = "0x296FEE8")]
	private IEnumerator MultiPing(string address, List<PingInfo> infos, TaskInfo task_info)
	{
		return null;
	}

	[Token(Token = "0x601A36D")]
	[Address(RVA = "0x296FFC0", Offset = "0x296FFC0", VA = "0x296FFC0")]
	private void OnPingCompleted(string address, List<PingInfo> infos, TaskInfo task_info)
	{
	}

	[Token(Token = "0x601A36E")]
	[Address(RVA = "0x2970568", Offset = "0x2970568", VA = "0x2970568")]
	public void TraceRoute(ETaskType type, string[] address_list, uint thread_count, MultiTaskComplete call_back, [Optional] object extra_data)
	{
	}

	[Token(Token = "0x601A36F")]
	[Address(RVA = "0x2970A78", Offset = "0x2970A78", VA = "0x2970A78")]
	private void TraceRoute(string address, int thread_count)
	{
	}

	[Token(Token = "0x601A370")]
	[Address(RVA = "0x2970B88", Offset = "0x2970B88", VA = "0x2970B88")]
	private void OnTraceRouteTaskComplete(TracerouteResult result)
	{
	}

	[Token(Token = "0x601A371")]
	[Address(RVA = "0x2970CC0", Offset = "0x2970CC0", VA = "0x2970CC0")]
	public void OnTraceRouteCompleted(string data)
	{
	}

	[Token(Token = "0x601A372")]
	[Address(RVA = "0x29711B4", Offset = "0x29711B4", VA = "0x29711B4")]
	public void CDNDownload(string url, MultiTaskComplete call_back)
	{
	}

	[Token(Token = "0x601A373")]
	[Address(RVA = "0x29712FC", Offset = "0x29712FC", VA = "0x29712FC")]
	private IEnumerator TestCDN(string url)
	{
		return null;
	}

	[Token(Token = "0x601A374")]
	[Address(RVA = "0x2970398", Offset = "0x2970398", VA = "0x2970398")]
	private void OnTaskComplete(TaskInfo task_info)
	{
	}

	[Token(Token = "0x601A375")]
	[Address(RVA = "0x29713C4", Offset = "0x29713C4", VA = "0x29713C4")]
	private void Update()
	{
	}
}
