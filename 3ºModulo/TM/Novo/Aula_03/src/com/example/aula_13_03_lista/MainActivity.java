package com.example.aula_13_03_lista;

import java.util.ArrayList;

import android.app.Activity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.*;

	

public class MainActivity extends Activity {

	EditText editText1;
	ArrayList<String> list = new ArrayList<String>();
	ArrayAdapter<String> adapter;
	ListView listView;
	
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        listView = (ListView)findViewById(R.id.listView1);
        editText1 = (EditText)findViewById(R.id.editText1);
        adapter = new ArrayAdapter<String>(this, android.R.layout.simple_dropdown_item_1line);
        Button btnAdd = (Button)findViewById(R.id.button1);
        
        btnAdd.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				String produto = editText1.getText().toString();
				list.add(produto);
				listView.setAdapter(adapter);
			}
		});
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();
        if (id == R.id.action_settings) {
            return true;
        }
        return super.onOptionsItemSelected(item);
    }
}
