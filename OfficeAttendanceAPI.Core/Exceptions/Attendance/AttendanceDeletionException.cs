namespace OfficeAttendanceAPI.Core.Exceptions.Attendance;

public class AttendanceDeletionException(string message, Exception innerException)
    : Exception(message, innerException);
