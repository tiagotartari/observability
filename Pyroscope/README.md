
## Using K6 as a Stress Test Tool

This particular test script is designed to run for 5 minutes with 10 Virtual Users. A Virtual User (VU) in k6 is akin to an individual user or connection interacting with the target system. This test script simulates the behavior of these users over the test period.

## How to Run the Test

To run the test, you will need to have k6 installed on your machine. After installing k6, you can run the test using the following command in the terminal:

`k6 run --vus 10 --duration 5m script.js` 

This command tells k6 to execute the test script `script.js` for 5 minutes, using 10 Virtual Users.

## Contributing

This is an open-source project, and contributions are welcome! If you've found an issue or have a suggestion for improvement, feel free to open an issue or submit a pull request.

## Useful Links
-   [K6.io, Grafana and InfluxDb is the best stack for stress testing](https://tiagotartari.net/k6-grafana-e-influxdb-e-a-melhor-stack-para-stress-test.html)
-   [Official k6 documentation](https://k6.io/docs/)
-   [k6 Getting Started Guide](https://k6.io/docs/getting-started/)