namespace Rhino.Etl.Core.Infrastructure
{
    using System.Data.SqlClient;

    /// <summary>
    /// Stores the SqlCommand and the Row.
    /// </summary>
    public class SqlCommandWithRow
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlCommandWithRow"/> class.
        /// </summary>
        public SqlCommandWithRow()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlCommandWithRow"/> class.
        /// </summary>
        /// <param name="command">
        /// The command.
        /// </param>
        /// <param name="row">
        /// The row.
        /// </param>
        public SqlCommandWithRow(SqlCommand command, Row row)
        {
            Command = command;
            Row = row;
        }

        /// <summary>
        /// Gets or sets the command.
        /// </summary>
        public SqlCommand Command { get; set; }

        /// <summary>
        /// Gets or sets the row.
        /// </summary>
        public Row Row { get; set; }
    }
}
