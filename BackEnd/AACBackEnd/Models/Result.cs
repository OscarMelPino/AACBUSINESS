using System.Runtime.Serialization;

namespace AACBackEnd.Models
{
    public class Result<T>
    {
        /// <summary>
        /// This class represents a result item used for returning the outcome of any operation.
        /// </summary>
        /// <summary>
        /// Default constructor for the <see cref="Result"/> class. The default constructor initializes a
        /// successful result by calling the parameterized constructor with the <see cref="IsSuccessful"/>
        /// argument as <see langword="true"/>.
        /// </summary>
        /// 

        public Result() : this(true)
        { }

        public Result(T value) : this(true)
        {
            Value = value;
        }

        /// <summary>
        /// Gets or sets the value generated for the operation as successful result.
        /// </summary>
        public T? Value { get; init; }

        /// <summary>
        /// Parameterized constructor for the Result class that sets the <see cref="IsSuccessful"/> property.
        /// </summary>
        /// <param name="isSuccessful">A boolean value indicating whether the operation was successful or not.</param>
        public Result(bool isSuccessful)
        {
            IsSuccessful = isSuccessful;
        }



        /// <summary>
        /// Parameterized constructor for the Result class that sets the Exception property and sets <see
        /// cref="IsSuccessful"/> to <see langword="false"/>. This constructor is used when the operation results
        /// in an exception (so is not successful).
        /// </summary>
        /// <param name="exception">
        /// An <see cref="System.Exception"/> object representing the exception that occurred during the operation.
        /// </param>
        public Result(Exception exception) : this(false)
        {
            Exception = new(exception.Message) { HResult = 0 };
        }



        /// <summary>
        /// Gets or sets the exception that occurred during the operation.
        /// </summary>
        [DataMember]
        public Exception? Exception { get; init; }



        /// <summary>
        /// Gets or sets whether the operation was successful or not.
        /// </summary>
        [DataMember]
        public bool IsSuccessful { get; init; }
    }
}

